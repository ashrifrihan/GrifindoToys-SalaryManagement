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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void bt_emp_Click(object sender, EventArgs e)
        {
            loadform(new employee());

        }

        private void bt_atnd_Click(object sender, EventArgs e)
        {
            loadform(new Attandance());

        }

        private void bt_exper_Click(object sender, EventArgs e)
        {
            loadform(new experience());
        }

        private void bt_gender_Click(object sender, EventArgs e)
        {
            loadform(new gender());
        }

        private void bt_leave_Click(object sender, EventArgs e)
        {

            loadform(new leave());
        }

        private void bt_apl_leave_Click(object sender, EventArgs e)
        {
            loadform(new applied_Leaves());

        }

        private void bt_holiday_Click(object sender, EventArgs e)
        {
            loadform(new Holiday());

        }

        private void bt_salary_Click(object sender, EventArgs e)
        {
            loadform(new salary());

        }

        private void bt_setting_Click(object sender, EventArgs e)
        {
            loadform(new setting());

        }

        private void bt_admin_Click(object sender, EventArgs e)
        {
            loadform(new admin());

        }

        private void bt_salary_conculation_Click(object sender, EventArgs e)
        {
            new salaryColculation().Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
            MessageBox.Show("You have been logged out", "Loggedout ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
