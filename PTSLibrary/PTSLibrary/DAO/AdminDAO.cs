using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace PTSLibrary.DAO
{
    internal class AdminDAO :SuperDAO
    {
        public int Authenticate(string username, string password)
        {
            string sql = String.Format("SELECT UserId FROM person WHERE Username = '{0}' AND Password = '{1}'",
                username, password);
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            int id = 0;
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = (int)dr["UserId"];
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Accessing the Database", ex);
            }
            finally
            {
                cn.Close();
            }
            return id;
        }

        // create project
        public void CreateProject(string name, DateTime startDate, DateTime endDate, int customerId, int administratorId)
        {
            Guid projectid = Guid.NewGuid();
            string sql = "INSERT INTO Project (ProjectId, Name, ExpectedStartDate, ExpectedEndDate, CustomerId, AdministratorId)";
            sql += String.Format("VALUES('{0}', '{1}','{2}','{3}', {4}, {5})", projectid, name, startDate.ToString("yyyy-MM-dd HH:mm:ss"), endDate.ToString("yyyy-MM-dd HH:mm:ss"), customerId, administratorId);
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error creating  Project",ex);
            }
            finally
            {
                cn.Close();
            }

        }

        // update project
        public void UpdateProject(string name, DateTime startDate, DateTime endDate, int customerId, int administratorId,Guid projectID)
        {
           string sql = String.Format("UPDATE Project SET Name = '{0}', ExpectedStartDate ='{1}', ExpectedEndDate='{2}', CustomerId={3}, " +
              "AdministratorId={4} WHERE ProjectID = '{5}'", name, startDate.ToString("yyyy-MM-dd HH:mm:ss"), endDate.ToString("yyyy-MM-dd HH:mm:ss"), customerId, administratorId, projectID);
  
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating  Project", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        // delete project
        public void DeleteProject(Guid id)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd;
            sql = String.Format("DELETE FROM project WHERE ProjectID='{0}'", id);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error deleting project", ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void CreateTask(string name, DateTime startDate, DateTime endDate, int teamId, Guid projectId)
        {
            Guid taskId = Guid.NewGuid();
            string sql = "INSERT INTO Task (TaskId, Name, ExpectedDateStarted, ExpectedDateCompleted,ProjectId,TeamId,StatusId)";
            sql += String.Format("VALUES('{0}', '{1}','{2}','{3}', '{4}', {5},{6})", taskId, name, startDate.ToString("yyyy-MM-dd HH:mm:ss"), endDate.ToString("yyyy-MM-dd HH:mm:ss"), projectId, teamId,1);
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Creating Task",ex);
            }
            finally
            {
                cn.Close();
            }
        }
        //Create Cohort
        public void CreateTeam(int id,string name)
        {
          
            string sql;
            SqlConnection con = new(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd;
            sql = "INSERT INTO Team(TeamId,name)";
            sql += String.Format("VALUES ({0},'{1}')",id, name);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error creating new cohort", ex);
            }
            finally
            {
                con.Close();
            }
        }
        public List<Customer> GetListOfCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string sql = " SELECT * FROM Customers";
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Customer custom = new Customer(dr["Name"].ToString(), (int)dr["CustomerId"]);
                    customers.Add(custom);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting list of Customers", ex);
            }
            finally
            {
                cn.Close();
            }

            return customers;
        }
        public List<Team> GetListOfTeams()
        {
            List<Team> teams = new List<Team>();
            string sql = "SELECT * FROM Team";
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Team team = new Team((int)dr["TeamId"], dr["Name"].ToString(),dr["Location"].ToString());
                    teams.Add(team);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting list of Teams", ex);
            }
            finally
            {
                cn.Close();
            }
            return teams;
        }
        public List<Task> GetListOfTasks(Guid projectId)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<Task> tasks;
            tasks = new List<Task>();

            sql = "SELECT * FROM Task WHERE ProjectId = '" + projectId + "'";
            cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Task t = new Task((Guid)dr["TaskId"], dr["Name"].ToString(), (Status)((int)dr["StatusId"]));
                    tasks.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting task list", ex);
            }
            finally
            {
                cn.Close();
            }
            return tasks;
        }

        public List<Project> GetListOfProjects()
        {
            List<Project> projects = new List<Project>();
            string sql = " SELECT * FROM Project " ;
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Customer cust = GetCustomer((int)dr["CustomerID"]);
                    Project p = new Project(dr["Name"].ToString(), (DateTime)dr["ExpectedStartDate"], (DateTime)dr["ExpectedEndDate"], (Guid)dr["ProjectID"],cust);
                    projects.Add(p);

                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting list of projects created by this administartor", ex);
            }
            finally
            {
                cn.Close();
            }
            return projects;
        }
        // getteamleaders method
        public List<TeamLeader> GetLeaders()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
           List<TeamLeader> leader = new List<TeamLeader>();

            sql = "SELECT * FROM Person WHERE UserId != 1" ;
            cn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                dr.Read();
               TeamLeader l = new TeamLeader(dr["name"].ToString());

                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return leader;
        }





    }
}
