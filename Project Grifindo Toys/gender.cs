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
    public partial class gender : Form
    {
        public gender()
        {
            InitializeComponent();
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string gendername = txt_genderName.Text;
            string sql = $"INSERT INTO Gender (Gender_name) VALUES ('{gendername}')";
            Database.save(sql);
            loadtabTableFunction();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gender_Load(object sender, EventArgs e)
        {
            loadtabTableFunction();
        }

        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT gender.Gender_id AS ID, gender.Gender_name AS Gender FROM gender", genderGridView);

        }

        private void genderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string AppliedID = genderGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select * from Gender where Gender.Gender_id = '{AppliedID}'";
            DataTable dt = Database.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                txt_genderID.Text = dt.Rows[0]["Gender_id"].ToString();
                txt_genderName.Text = dt.Rows[0]["Gender_name"].ToString();
            }
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"update gender set Gender_name = '{txt_genderName.Text}' where Gender_id = '{txt_genderID.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from gender where Gender_id = '{txt_genderID.Text}'";
            Database.delete(sql);
            loadtabTableFunction();
        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_genderID,
                txt_genderName

         });

            }
        }
    }
}
