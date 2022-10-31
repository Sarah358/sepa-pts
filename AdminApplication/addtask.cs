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
    public partial class addtask : UserControl
    {
        private PTSAdminFacade facade;
        private int adminId;
        private Customer[] customers;
        private Project[] projects;
        private Team[] teams;
        private Project selectedProject;
        private PTSLibrary.Task[] tasks;
        public addtask()
        {
            InitializeComponent();
            facade = new PTSAdminFacade();
            adminId = 0;
        }    
        private void addtask_Load(object sender, EventArgs e)
        {
            teams = facade.GetListOfTeams();
            cbteam.DataSource = teams;
            cbteam.DisplayMember = "Name";
            cbteam.ValueMember = "TeamId";

            // get list of projects
            projects = facade.GetListOfProjects();
            cbprojects.DataSource = projects;
            cbprojects.DisplayMember = "Name";
            cbprojects.ValueMember = "projectId";
            setProjectDetails();
        }
        private void newtask_Selected(object sender, TabControlEventArgs e)
        {
            // get list of projects
            projects = facade.GetListOfProjects();
            cbProject.DataSource = projects;
            cbProject.DisplayMember = "Name";
            cbProject.ValueMember = "projectId";
            setProjectDetails();

        }

        private void UpdateTasks()
        {
            tasks = facade.GetListOfTasks(selectedProject.projectId);
            cbtasks.DataSource = tasks;
            cbtasks.DisplayMember = "NameAndStatus";
            cbtasks.ValueMember = "TaskId";
            
       }
        private void setProjectDetails()
        {
            selectedProject = projects[cbprojects.SelectedIndex];
            UpdateTasks();
        }
        private void btnaddtask_Click(object sender, EventArgs e)
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
                startDate = DateTime.Parse(textstart2.Text);
                endDate = DateTime.Parse(textend2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The dates are in the wrong formart");
                return;
            }
           facade.CreateTask(textname.Text, startDate, endDate, (int)cbteam.SelectedValue, selectedProject.projectId);
            textname.Text = "";
            textstart2.Text = "";
            textend2.Text = "";
            cbteam.SelectedIndex = 0;
            MessageBox.Show("Task successfully created");
            UpdateTasks();

        }
    

        private void cbprojects_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProjectDetails();
        }

        private void comboBoxprojects_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProject = projects[cbProject.SelectedIndex];
            UpdateTasks();

        }
    

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
          



        }

        private void cbteam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
