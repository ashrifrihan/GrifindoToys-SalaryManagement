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
    public partial class experience : Form
    {
        public experience()
        {
            InitializeComponent();
        }

        private void txt_workend_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string employee_fk = combo_EmpFk.SelectedValue.ToString();
            string Previous_Working_place = txt_PreWokingPlace.Text;
            string Start_work_date = txt_workstart.Text;
            string workenddate = txt_workend.Text;
            string reason_of_resinging = txt_reason.Text;

            string sql = $"INSERT INTO Employee_Experience (Employee_Fk,Previous_Working_place, Start_work_date,End_work_date,Reason_of_resinging) VALUES ('{employee_fk} ', '{Previous_Working_place}', '{Start_work_date}','{workenddate}','{reason_of_resinging}')";
            Database.save(sql);
            loadtabTableFunction();

        }

        private void experience_Load(object sender, EventArgs e)
        {
            Database.loadFkDataInComboBox("SELECT * FROM Employee", combo_EmpFk, "Employee_id", "Employee_id");

            loadtabTableFunction();
            
        }

        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT * FROM Employee_Experience", experienceGridView);

        }

        private void experienceGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string AppliedID = experienceGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select * from Employee_Experience where Employee_Experience.Employee_Experience_id = '{AppliedID}'";
            DataTable dt = Database.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                txt_experince_id.Text = dt.Rows[0]["Employee_Experience_id"].ToString();
                combo_EmpFk.SelectedValue = dt.Rows[0]["Employee_Fk"].ToString();
                txt_PreWokingPlace.Text = dt.Rows[0]["Previous_Working_place"].ToString();
                txt_workstart.Text = dt.Rows[0]["Start_work_date"].ToString();
                txt_workend.Text = dt.Rows[0]["End_work_date"].ToString();
                txt_reason.Text = dt.Rows[0]["Reason_of_resinging"].ToString();
            }
        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_experince_id,
                txt_PreWokingPlace,
                txt_reason,
                combo_EmpFk,
                txt_workstart,
                txt_workend

         });

            }
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"update Employee_Experience set Reason_of_resinging = '{txt_reason.Text}',Employee_Fk = '{combo_EmpFk.SelectedValue.ToString()}', Previous_Working_place = '{txt_PreWokingPlace.Text}', Start_work_date = '{txt_workstart.Text}', End_work_date = '{txt_workend.Text}'  where Employee_Experience_id = '{txt_experince_id.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Employee_Experience where Employee_Experience_id = '{txt_experince_id.Text}'";
            Database.delete(sql);
            loadtabTableFunction();
        }
    }
}
