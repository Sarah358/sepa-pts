using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.DAO
{
    internal class CustomerDAO : SuperDAO
    {
        public int Aunthenticate(string username,string password)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;

            sql = String.Format("SELECT CustomerId FROM Customer WHERE Username='{0}' AND Password='{1}'", username, password);
            cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            cmd = new SqlCommand(sql, cn);
            int id = 0;
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = (int)dr["CustomerId"];
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Accessing Database",ex);
            }
            finally
            {
                cn.Close();
            }
            return id;
        }
        // function to get a list of the projects that a customer has commissioned.
        public List<Project> GetListOfProjects(int custid)
        {
            List<Project> projects = new List<Project>();
            string sql = "SELECT * FROM Projects WHERE CustomerId = " + custid;
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    List<Task> tasks = new List<Task>();
                    sql = "SELECT * FROM Task WHERE ProjectId = '" + dr["ProjectId"].ToString() + "'";
                   SqlConnection cn2 = new SqlConnection(Properties.Settings.Default.ConnectionString);
                   SqlCommand cmd2 = new SqlCommand(sql, cn2);
                    cn2.Open();
                   SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        Task t = new Task((Guid)dr2["TaskId"], dr2["Name"].ToString(), (Status)(int)dr2["StatusId"]);
                        tasks.Add(t);
                    }
                    dr2.Close();
                    Project p = new Project(dr["Name"].ToString(), (DateTime)dr["ExpectedStartDate"], (DateTime)dr["ExpectedEndDate"],
                       (Guid)dr["ProjectId"], tasks);
                    projects.Add(p);

                }
                dr.Close();
            }
            catch(SqlException ex)
            {
                throw new Exception("Error Getting list of projects", ex);

            }
            finally
            {
                cn.Close();
            }
            return projects;

        }
    }
}
