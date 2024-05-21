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
    public partial class admin : Form
    {
        public DataGridView myGrid { get; set; }

        public admin()
        {
            InitializeComponent();
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string username = txt_AdminUserName.Text;
            string password = txt_AdminPassword.Text;
            string sql = $"INSERT INTO Admin_as ([user_name] ,[Password] ) VALUES ( '{username} ', '{password}')";
            Database.save(sql);
            loadtabTableFunction();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            Database.loadDataFromDBtoDataGridView("select *from Admin_as", adminGridView);
            loadtabTableFunction();
        }

        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT Admin_as.Admin_ID AS ID, Admin_as.user_name AS UserName, Admin_as.Password AS Password FROM Admin_as", adminGridView);

        }



        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string AppliedID = adminGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select * from Admin_as where Admin_as.Admin_ID = '{AppliedID}'";
            DataTable dt = Database.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                txt_AdminID.Text = dt.Rows[0]["Admin_ID"].ToString();
                txt_AdminUserName.Text = dt.Rows[0]["user_name"].ToString();
                txt_AdminPassword.Text = dt.Rows[0]["Password"].ToString();
            }
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Admin_as where Admin_ID = '{txt_AdminID.Text}'";
            Database.delete(sql);
            loadtabTableFunction();

        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_AdminID,
                txt_AdminUserName,
                txt_AdminPassword,

         });

            }
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"update Admin_as set user_name = '{txt_AdminUserName.Text}', Password = '{txt_AdminPassword.Text}' where Admin_ID = '{txt_AdminID.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }
    }
}