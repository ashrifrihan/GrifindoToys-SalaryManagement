using Project_Grifindo_Toys.Class;
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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string admin_Fk = combo_AdminFk.SelectedValue.ToString();
            string salary_beging_date = datetxt_salaryBeginDate.Text;
            string salary_end_date = datetxt_salaryEndDate.Text;
            string num_of_leave_per_year = txt_numberOfPerYear.Text;
            string salarydurations = txt_salaryCycleDurations.Text;

            string sql = $"INSERT INTO Setting (Admin_Fk,Salary_Begin_date,Salary_End_date,num_of_leave_perYear,Salary_cycle_durations) VALUES ('{admin_Fk}','{salary_beging_date}','{salary_end_date}','{num_of_leave_per_year}','{salarydurations}')";
            Database.save(sql);
            loadtabTableFunction();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            Database.loadFkDataInComboBox("SELECT * FROM Admin_as ", combo_AdminFk, "Admin_ID", "Admin_ID");

            loadtabTableFunction();

        }

        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT Setting.Setting_id AS ID, Setting.Admin_Fk AS Admin_ID, Setting.Salary_Begin_date AS Salary_start_date, Setting.Salary_End_date AS Salary_End_Date, Setting.num_of_leave_perYear AS NumberofPerYear, Setting.Salary_cycle_durations AS Salary_DurationsDate From Setting JOIN Admin_as ON Setting.Admin_Fk = Admin_ID", settingGridView);

        }

        private void settingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string AppliedID = settingGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select * from Setting where Setting.Setting_id = '{AppliedID}'";
            DataTable dt = Database.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                txt_settingID.Text = dt.Rows[0]["Setting_id"].ToString();
                combo_AdminFk.SelectedValue = dt.Rows[0]["Admin_Fk"].ToString();
                datetxt_salaryBeginDate.Text = dt.Rows[0]["Salary_Begin_date"].ToString();
                datetxt_salaryEndDate.Text = dt.Rows[0]["Salary_End_date"].ToString();
                txt_numberOfPerYear.Text = dt.Rows[0]["num_of_leave_perYear"].ToString();
                txt_salaryCycleDurations.Text = dt.Rows[0]["Salary_cycle_durations"].ToString();
            }
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Setting where Setting_id = '{txt_settingID.Text}'";
            Database.delete(sql);
            loadtabTableFunction();
        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_settingID,
                txt_numberOfPerYear,
                txt_salaryCycleDurations,
                combo_AdminFk,
                datetxt_salaryBeginDate, 
                datetxt_salaryEndDate,

         });

            }
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"update Setting set num_of_leave_perYear = '{txt_numberOfPerYear.Text}', Admin_Fk = '{combo_AdminFk.SelectedValue.ToString()}',Salary_Begin_date = '{datetxt_salaryBeginDate.Text}',Salary_End_date = '{datetxt_salaryEndDate.Text}', Salary_cycle_durations = '{txt_salaryCycleDurations.Text}'  where Setting_id = '{txt_settingID.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }

    
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
