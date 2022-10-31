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
using static System.Windows.Forms.DataFormats;

namespace AdminApplication
{
    public partial class adminLogin : Form
    {
        private PTSAdminFacade facade;
        private int adminId;
        public adminLogin()
        {
            InitializeComponent();
            facade = new PTSAdminFacade();
            adminId = 0;
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            try
            {
                adminId = facade.Authenticate(this.txtUserName.Text, this.txtPassword.Text);
                if (adminId != 0 )
                {
                    this.txtUserName.Text = "";
                    this.txtPassword.Text = "";
                    MessageBox.Show("successfully logged in");
                    new frmAdmin().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong login details");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelclear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}