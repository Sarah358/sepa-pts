using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    public class Task
    {
        private Guid taskId;
        private string name;
        private Status status;

        public Guid TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Status theStatus
        {
            get { return status; }
            set { status = value; }
        }
        public string NameAndStatus
        {
            get { return name + "-" + status; }
        }
        public Task(Guid taskId, string name, Status status)
        {
            this.taskId = taskId;
            this.name = name;
            this.status = status;
        }
        public Task(Guid taskId, string name)
        {
            this.taskId = taskId;
            this.name = name;
            
        }
        public Task( string name)
        {
          
            this.name = name;
            
        }

    }
}
