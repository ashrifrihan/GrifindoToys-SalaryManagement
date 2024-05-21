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
    public partial class leave : Form
    {
        public leave()
        {
            InitializeComponent();
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string LeaveID = txt_LeaveID.Text;
            string AnnualLeave = txt_annualL.Text;
            string CasualLeave = txt_casualL.Text;

            string sql = $"INSERT INTO Leaves_Count (Anual_Leave,Casual_Leave) VALUES ('{AnnualLeave} ','{CasualLeave}')";
            Database.save(sql);
            loadtabTableFunction();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void leave_Load(object sender, EventArgs e)
        {
            loadtabTableFunction();
        }

        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT * FROM Leaves_Count", leaveGridView);

        }

        private void leaveGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string AppliedID = leaveGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select * from Leaves_Count where Leaves_Count.Leave_id = '{AppliedID}'";
            DataTable dt = Database.getDataFromDB(sql);

            txt_LeaveID.Text = dt.Rows[0]["Leave_id"].ToString();
            txt_annualL.Text = dt.Rows[0]["Anual_Leave"].ToString();
            txt_casualL.Text = dt.Rows[0]["Casual_Leave"].ToString();
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Leaves_Count where Leave_id = '{txt_LeaveID.Text}'";
            Database.delete(sql);
            loadtabTableFunction();
        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_LeaveID,
                txt_annualL,
                txt_casualL,


         });

            }
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"update Leaves_Count set Anual_Leave = '{txt_annualL.Text}',Casual_Leave = '{txt_casualL.Text}'  where Leave_id = '{txt_LeaveID.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }
    }
}
