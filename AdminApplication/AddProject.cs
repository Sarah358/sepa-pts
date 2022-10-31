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
    public partial class AddProject : UserControl
    {
        private PTSAdminFacade facade;
        private int adminId;
        private Customer[] customers;
        private Project[] projects;
        private Team[] teams;  
        public static Project selectedProject;
        private PTSLibrary.Task[] tasks;
        public AddProject()
        {
            InitializeComponent();
            facade = new PTSAdminFacade();
            adminId = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProject_Load(object sender, EventArgs e)
        {

            customers = facade.GetListOfCustomers();
            cbcust.DataSource = customers;
            cbcust.DisplayMember = "Name";
            cbcust.ValueMember = "id";
        }

        private void btnaddproject_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            if(textname.Text == "")
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
            facade.CreateProject(textname.Text, startDate, endDate, (int)cbcust.SelectedValue, adminId);
            textname.Text = "";
            textstart.Text = "";
            textend.Text = "";
            cbcust.SelectedIndex = 0;
            MessageBox.Show("Project successfully created");
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            // get list of projects
            projects = facade.GetListOfProjects();
            cbProjects.DataSource = projects;
            cbProjects.DisplayMember = "Name";
            cbProjects.ValueMember = "projectId";
           setProjectDetails();

            //get list of teams
           // teams = facade.GetListOfTeams();
        }
        public void setProjectDetails()
        {
            selectedProject = projects[cbProjects.SelectedIndex];
            lblStartDate.Text = selectedProject.expectedStartDate.ToShortDateString();
            lblEndDate.Text = selectedProject.expectedEndDate.ToShortDateString();
            labelcustomer.Text = ((Customer)selectedProject.theCustomer).Name;  
           

        }

        private void comboBoxteam_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void buttonedit_Click(object sender, EventArgs e)
        {

            selectedProject = projects[cbProjects.SelectedIndex];
            new editproject().Show();
            setProjectDetails();
        }

        private void cbProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

            setProjectDetails();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
           new deleteproject().Show();
           

        }
    }
}
