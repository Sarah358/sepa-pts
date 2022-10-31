using PTSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTSLibrary;

namespace AdminApplication
{
    public partial class frmAdmin : Form
    {
        private Customer[] customers;
        private Project[] projects;
        private Team[] teams;
        private PTSLibrary.Task[] tasks;

        public frmAdmin()
        {
            
            InitializeComponent();
            home uc = new home();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

     

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            buttonmax.Visible = false;
            buttonmaxed.Location = buttonmax.Location;
            buttonmaxed.Visible = true;
        }

        private void buttonmin_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
            buttonmin.Visible = false;
        }

        private void buttonmaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonmaxed.Visible = false;
            buttonmax.Visible=true; 
        }

        private void buttonprojects_Click(object sender, EventArgs e)
        {
            labelhome.Text = "Projects";
            AddProject uc = new AddProject();
            addUserControl(uc);
            if (buttonprojects.Focused == true)
            {
                buttonprojects.BackColor = Color.DarkSlateGray;
                buttonhome.BackColor = menu.BackColor;
                buttontasks.BackColor = menu.BackColor;
                buttonusers.BackColor = menu.BackColor;


            }
          


        }
      

        private void buttonhome_Click(object sender, EventArgs e)
        {
            labelhome.Text = "Home";
          
            home uc = new home();
            addUserControl(uc);
            if (buttonhome.Focused == true)
            {
                buttonhome.BackColor = Color.DarkSlateGray;
                buttonprojects.BackColor = menu.BackColor;
                buttontasks.BackColor = menu.BackColor;
                buttonusers.BackColor = menu.BackColor;
            }



        }
        private void buttontasks_Click(object sender, EventArgs e)
        {
            labelhome.Text = "Tasks";
            addtask uc = new addtask();
            addUserControl(uc);
            if (buttontasks.Focused == true)
            {
                buttontasks.BackColor = Color.DarkSlateGray;
                buttonhome.BackColor = menu.BackColor;
                buttonprojects.BackColor = menu.BackColor;
                buttonusers.BackColor = menu.BackColor;


            }


        }
        private void buttonusers_Click(object sender, EventArgs e)
        {
            labelhome.Text = "Manage Users";
            manageusers uc = new manageusers();
            addUserControl(uc);
            if (buttonusers.Focused == true)
            {
                buttonusers.BackColor = Color.DarkSlateGray;
                buttonhome.BackColor = menu.BackColor;
                buttonprojects.BackColor = menu.BackColor;
                buttontasks.BackColor = menu.BackColor;


            }


        }

        private void panelhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addProject1_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("successfully logged out");
            new adminLogin().Show();
            this.Hide();
        }
    }
}
