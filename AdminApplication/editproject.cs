using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTSLibrary;

namespace AdminApplication
{
    public partial class editproject : Form
    {
        private PTSAdminFacade facade;
        private int adminId;
        private Customer[] customers;
        Guid projectID = AddProject.selectedProject.projectId;


        public editproject()
        {
            InitializeComponent();
            facade = new PTSAdminFacade();
            adminId = 0;
          


        }

        private void editproject_Load(object sender, EventArgs e)
        {
            customers = facade.GetListOfCustomers();
            cbcust.DataSource = customers;
            cbcust.DisplayMember = "Name";
            cbcust.ValueMember = "id";
            Text = AddProject.selectedProject.name;
           textname.Text = AddProject.selectedProject.name;
            textstart.Text = AddProject.selectedProject.expectedStartDate.ToShortDateString();
            textend.Text = AddProject.selectedProject.expectedEndDate.ToShortDateString();
            cbcust.Text =  ((Customer)AddProject.selectedProject.theCustomer).Name;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            new AddProject().Show();
            this.Close();
        }
        

        private void btnaddproject_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            if (textname.Text == "")
            {
                MessageBox.Show("You need to fill the name field");
                return;
            }
            try
            {
                startDate = DateTime.Parse(textstart.Text);
                endDate = DateTime.Parse(textend.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The dates are in the wrong formart");
                return;
            }
            facade.UpdateProject(textname.Text, startDate, endDate, (int)cbcust.SelectedValue, adminId,projectID);
            textname.Text = "";
            textstart.Text = "";
            textend.Text = "";
            cbcust.SelectedIndex = 0;
            MessageBox.Show("Project successfully updated");
            this.Close();
          new AddProject().Show();
         
        }
    }
}
