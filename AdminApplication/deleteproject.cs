using PTSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApplication
{
    public partial class deleteproject : Form
    {
        private PTSAdminFacade facade;
     
        Guid ID = AddProject.selectedProject.projectId;
        public deleteproject()
        {
            InitializeComponent();
            facade = new PTSAdminFacade();
          
        }

        private void btndeleteproject_Click(object sender, EventArgs e)
        {
            facade.DeleteProject(ID);
            new AddProject().Show();
            MessageBox.Show("Project deleted successfuly");
            Close();


        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            new AddProject().Show();
            this.Close();
        }

        private void deleteproject_Load(object sender, EventArgs e)
        {
            Text = AddProject.selectedProject.name;

        }
    }
}
