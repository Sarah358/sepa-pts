using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    public class Project
    {
        public string name { get; set; }
        public DateTime expectedStartDate { get; set; }
        public DateTime expectedEndDate { get; set; }
        public Customer theCustomer { get; set; }
        public Guid projectId { get; set; }
        public List<Task> tasks { get; set; }

        public Project(string name, DateTime expectedStartDate, DateTime expectedEndDate)
        {
            this.name = name;
            this.expectedStartDate = expectedStartDate;
            this.expectedEndDate = expectedEndDate;

           

        }
        public Project(string name, DateTime expectedStartDate, DateTime expectedEndDate,  Guid projectId,Customer customer)
        {
            this.name = name;
            this.expectedStartDate = expectedStartDate;
            this.expectedEndDate = expectedEndDate;
            this.projectId = projectId;
            this.theCustomer = customer;
           
          
        }
        public Project(string name, DateTime expectedStartDate, DateTime expectedEndDate, Guid projectId, List<Task> tasks) 
        {
            this.name = name;
            this.expectedStartDate = expectedStartDate;
            this.expectedEndDate = expectedEndDate;
            this.projectId = projectId;
            this.tasks = tasks;
        }
    }
}
