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
    public partial class Attandance : Form
    {
        public Attandance()
        {
            InitializeComponent();
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string intime = txt_inTime.Text;
            string outtime = txt_outTime.Text;
            string employee_fk = combo_EmpFk.SelectedValue.ToString();

            string sql = $"INSERT INTO Employee_Attendance ( In_time,Out_time,Employee_FK ) VALUES (' {intime}','{outtime}','{employee_fk}')";
            Database.save(sql);
            loadtabTableFunction();
        }

        private void Attandance_Load(object sender, EventArgs e)
        {
            Database.loadFkDataInComboBox("SELECT * FROM Employee", combo_EmpFk, "Employee_id", "Employee_id");
            loadtabTableFunction();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT Employee_Attendance.Attendance_id AS ID,Employee_Attendance.In_time AS  InTime,Employee_Attendance.Out_time AS OutTime,Employee_Attendance.Employee_FK AS Employee_ID FROM Employee_Attendance JOIN employee ON Employee_Attendance.Employee_FK = employee_id", attendanceGridView);

        }

        private void attendanceGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string AppliedID = attendanceGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select * from Employee_Attendance where Employee_Attendance.Attendance_id = '{AppliedID}'";
            DataTable dt = Database.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                txt_Attn_id.Text = dt.Rows[0]["Attendance_id"].ToString();
                txt_outTime.Text = dt.Rows[0]["In_time"].ToString();
                txt_outTime.Text = dt.Rows[0]["Out_time"].ToString();
                combo_EmpFk.SelectedValue = dt.Rows[0]["Employee_FK"].ToString();

            }
        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_Attn_id,
                txt_inTime,
                txt_outTime,
                combo_EmpFk

         });

            }
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Employee_Attendance where Attendance_id = '{txt_Attn_id.Text}'";
            Database.delete(sql);
            loadtabTableFunction();
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"update Employee_Attendance set In_time = '{txt_inTime.Text}', Out_time = '{txt_outTime.Text}', Employee_FK = '{combo_EmpFk.SelectedValue.ToString()}'  where Attendance_id = '{txt_Attn_id.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }
    }
}
