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
using static System.Net.Mime.MediaTypeNames;

namespace AdminApplication
{
    public partial class manageusers : UserControl
    {
        private PTSAdminFacade facade;
        private Team[] teams;
        private TeamLeader[] teamLeaders;
        private int id;

        public manageusers()
        {
            InitializeComponent();
            facade = new PTSAdminFacade();
            id = 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void manageusers_Load(object sender, EventArgs e)
        {
            teamLeaders = facade.GetLeaders();
            comboBox1.DataSource = teamLeaders;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "id";

        }
        private void buttonaddteam_Click(object sender, EventArgs e)
        {
            if (textBoxteam.Text == "")
            {
                MessageBox.Show("You need to fill the name field");
                return;
            }
           
            facade.CreateTeam(id,textBoxteam.Text);
            textBoxteam.Text = "";
            MessageBox.Show("Team successfully created");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmAdmin().Show();
            this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
