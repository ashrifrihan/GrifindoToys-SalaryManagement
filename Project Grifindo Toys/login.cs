using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Grifindo_Toys
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Btu_Click(object sender, EventArgs e)
        {
            {
                string username = txt_userName.Text;
                string password = txt_password.Text;
                if (txt_userName.Text == "admin" && txt_password.Text == "admin")
                {
                    MessageBox.Show("Login_Successfully", "Login_Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    dashboard Loginform = new dashboard();
                    Loginform.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Insert correct username and password");
                }
            }
        }

        private void checkBox_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show.Checked== true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
    }
}
