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
    public partial class Holiday : Form
    {
        public Holiday()
        {
            InitializeComponent();
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string count_of_holidays = txt_CountHoliday.Text;
            string permonths = monthTextBox.Text;

            string sql = $"INSERT INTO No_of_holiday (count_of_Holidays,months) VALUES ('{count_of_holidays} ','{permonths}');";
            Database.save(sql);
            loadtabTableFunction();
        }

        private void Holiday_Load(object sender, EventArgs e)
        {
            loadtabTableFunction();
        }

        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT No_of_holiday.Holiday_id AS ID,No_of_holiday.count_of_Holidays AS Count_Holidays, No_of_holiday.months AS Month From No_of_holiday", holidatGridView);

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void holidatGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string AppliedID = holidatGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select * from No_of_holiday where No_of_holiday.Holiday_id = '{AppliedID}'";
            DataTable dt = Database.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                txt_holidayID.Text = dt.Rows[0]["Holiday_id"].ToString();
                txt_CountHoliday.Text = dt.Rows[0]["count_of_Holidays"].ToString();
                monthTextBox.Text = dt.Rows[0]["months"].ToString();
                
            }
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from No_of_holiday where Holiday_id = '{txt_holidayID.Text}'";
            Database.delete(sql);
            loadtabTableFunction();
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"update No_of_holiday set count_of_Holidays = '{txt_CountHoliday.Text}', months = '{monthTextBox.Text}' where Holiday_id = '{txt_holidayID.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_holidayID,
                txt_CountHoliday,
                monthTextBox,

         });

            }
        }
    }
}
