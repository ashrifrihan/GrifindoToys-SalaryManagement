using Project_Grifindo_Toys.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Project_Grifindo_Toys
{
    public partial class applied_Leaves : Form
    {
        public applied_Leaves()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string employee_fk = combo_EmpFk.SelectedValue.ToString();
            string leaveStartDate = txt_Leavestart.Text;
            string leaveEndDate = txt_leaveend.Text;
            string reason_of_leave = txt_reason.Text;

            string sql = $"INSERT INTO Applied_Leaves (Employee_Fk,Start_Leave_Date,End_Leave_Date,Reason_of_leave) VALUES ('{employee_fk}','{leaveStartDate}', '{leaveEndDate}','{reason_of_leave}')";
            Database.save(sql);
            loadtabTableFunction();

        }
        private void loadDataFromDBtoDataGridview()
        {
        }

        private void applied_Leaves_Load(object sender, EventArgs e)
        {
            Database.loadFkDataInComboBox("SELECT * FROM Employee", combo_EmpFk, "Employee_id", "Employee_name");

            loadtabTableFunction();

        }
        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT Applied_Leaves.Appliend_Leave_Id AS ID, Applied_Leaves.Start_Leave_Date AS StartDate, Applied_Leaves.End_Leave_Date AS EndDate,Applied_Leaves.Reason_of_leave AS Reason, Applied_Leaves.Employee_Fk AS Employee_ID FROM Applied_Leaves JOIN employee ON Applied_Leaves.Employee_FK = employee_id", appliedDataGridView);

        }

        private void appliedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string AppliedID = appliedDataGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select *from Applied_Leaves where Applied_Leaves.Appliend_Leave_Id = '{AppliedID}'";
            DataTable dt = Database.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                txt_appliedID.Text = dt.Rows[0]["Appliend_Leave_Id"].ToString();
                combo_EmpFk.SelectedValue = dt.Rows[0]["Employee_Fk"].ToString();
                txt_Leavestart.Text = dt.Rows[0]["Start_Leave_Date"].ToString();
                txt_leaveend.Text = dt.Rows[0]["End_Leave_Date"].ToString();
                txt_reason.Text = dt.Rows[0]["Reason_of_leave"].ToString() ;
            }

        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_appliedID,
                combo_EmpFk,
                txt_Leavestart,
                txt_leaveend,
                txt_reason,

         });

            }
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Applied_Leaves where Appliend_Leave_Id = '{txt_appliedID.Text}'";
            Database.delete(sql);
            loadtabTableFunction();
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"update Applied_Leaves set Start_Leave_Date = '{txt_Leavestart.Text}', Employee_Fk = '{combo_EmpFk.SelectedValue.ToString()}', End_Leave_Date = '{txt_leaveend.Text}', Reason_of_leave = '{txt_reason.Text}'  where Appliend_Leave_Id = '{txt_appliedID.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }
    }
}
