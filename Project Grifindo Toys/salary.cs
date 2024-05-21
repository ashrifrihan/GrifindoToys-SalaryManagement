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
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string monthSalary = txt_monthSal.Text;
            string overTimeRate = txt_Ovrtimerate.Text;
            string basepay =  txt_basePay.Text;
            string grosspay = txt_grossPay.Text;
            string employee_fk = combo_EmpFk.SelectedValue.ToString();
            string nopayDurations = txt_noPay.Text;
            string holiday_fk = combo_holidayFk.SelectedValue.ToString();
            string total_leave_days_count = txt_total_leave_days_count.Text;

            string sql = $"insert into Salary (Month_Salary,Over_time_rate,Base_pay,Gross_pay,Employee_Fk,No_pay_durations,Holiday_Fk,total_leave_days_count) values ('{monthSalary}','{overTimeRate}','{basepay}','{grosspay}','{employee_fk}','{nopayDurations}','{holiday_fk}','{total_leave_days_count}')";
            Database.save(sql);
            loadtabTableFunction();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salary_Load(object sender, EventArgs e)
        {
            Database.loadFkDataInComboBox("SELECT * FROM Employee", combo_EmpFk, "Employee_id", "Employee_id");
            Database.loadFkDataInComboBox("SELECT * FROM No_of_holiday", combo_holidayFk, "Holiday_id", "Holiday_id");
            loadtabTableFunction();

        }

        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT Salary.Salary_id AS ID, Salary.Month_Salary AS MonthSalary,Salary.Over_time_rate AS OverTimeRate, Salary.Base_pay AS BasePay, Salary.Gross_pay AS GrossPay, Salary.No_pay_durations AS NoPayDurations,Salary.total_leave_days_count AS TotalLeavedays, Salary.Holiday_Fk AS Holiday_ID,Salary.Employee_Fk AS Employee_ID FROM Salary JOIN employee ON Salary.Employee_FK = employee_id JOIN No_of_holiday ON Salary.Holiday_Fk = Holiday_id", salaryGridView);

        }

        private void salaryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string AppliedID = salaryGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select * from Salary where Salary.Salary_id = '{AppliedID}'";
            DataTable dt = Database.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                txt_salaryID.Text = dt.Rows[0]["Salary_id"].ToString();
                txt_monthSal.Text = dt.Rows[0]["Month_Salary"].ToString();
                txt_Ovrtimerate.Text = dt.Rows[0]["Over_time_rate"].ToString();
                txt_basePay.Text = dt.Rows[0]["Base_pay"].ToString();
                txt_grossPay.Text = dt.Rows[0]["Gross_pay"].ToString();
                combo_EmpFk.SelectedValue = dt.Rows[0]["Employee_Fk"].ToString();
                txt_noPay.Text = dt.Rows[0]["No_pay_durations"].ToString();
                combo_holidayFk.SelectedValue = dt.Rows[0]["Holiday_Fk"].ToString();
                txt_total_leave_days_count.Text = dt.Rows[0]["total_leave_days_count"].ToString();

            }
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"update Salary set Month_Salary = '{txt_monthSal.Text}' where Salary_id = '{txt_salaryID.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Salary where Salary_id = '{txt_salaryID.Text}'";
            Database.delete(sql);
            loadtabTableFunction();
        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_salaryID,
                txt_monthSal,
                txt_Ovrtimerate,
                txt_basePay,
                txt_grossPay,
                txt_noPay,
                combo_EmpFk, 
                combo_holidayFk,
                txt_total_leave_days_count

         });

            }
        }
    }
}
