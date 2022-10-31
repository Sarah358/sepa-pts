using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    public class PTSAdminFacade : PTSSuperFacade
    {
        private DAO.AdminDAO dao;
        public PTSAdminFacade() : base(new DAO.AdminDAO())
        {
            dao = (DAO.AdminDAO)base.dao;
        }
        public int Authenticate(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }
        // create project
        public void CreateProject(string name, DateTime startDate, DateTime endDate, int customerId, int administratorId)
        {
            if (name == null || name == "" || startDate == null || endDate == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateProject(name, startDate, endDate, customerId, administratorId);
        }
        // update project
        public void UpdateProject(string name, DateTime startDate, DateTime endDate, int customerId, int administratorId,Guid projectID)
        {
            if (name == null || name == "" || startDate == null || endDate == null)
            {
                throw new Exception("Missing Data");
            }
            dao.UpdateProject(name, startDate, endDate, customerId, administratorId, projectID);
        }
        //Delete project
        public void DeleteProject(Guid id)
        {
            dao.DeleteProject(id);
        }
        public void CreateTask(string name, DateTime startDate, DateTime endDate, int teamId, Guid projectId)
        {
            if (name == null || name == "" || startDate == null || endDate == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateTask(name, startDate, endDate, teamId, projectId);
        }
        public Customer[] GetListOfCustomers()
        {
            return (dao.GetListOfCustomers()).ToArray();
        }
        public Project[] GetListOfProjects()
        {
            return (dao.GetListOfProjects()).ToArray();

        }
        public TeamLeader[] GetLeaders()
        {
            return (dao.GetLeaders()).ToArray();

        }
        public Task[] GetListOfTasks(Guid projectId)
        {
            return (dao.GetListOfTasks(projectId)).ToArray();
        }
        public Team[] GetListOfTeams()
        {
            return (dao.GetListOfTeams()).ToArray();
        }
        //Create Cohort
        public void CreateTeam(int id,string name)
        {
            dao.CreateTeam(id,name);
        }



    }
}
