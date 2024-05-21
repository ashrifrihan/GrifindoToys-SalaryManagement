using Project_Grifindo_Toys.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Grifindo_Toys
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            empGridView.ForeColor = Color.Black;
            

            Database.loadFkDataInComboBox("SELECT *FROM Gender", comBox_GenderFk, "Gender_id", "Gender_name");
            Database.loadFkDataInComboBox("SELECT * FROM Leaves_Count", comBox_LeaveCountFk, "Leave_id", "Leave_id");
            Database.loadFkDataInComboBox("SELECT * FROM Admin_as", comBox_AdminFk, "Admin_ID", "user_name");
            loadtabTableFunction();

        }


        private void loadtabTableFunction()
        {
            Database.loadDataFromDBtoDataGridView("SELECT employee.employee_id AS ID, employee.Employee_name AS Name, employee.Employee_mobile AS Mobile,employee.Employee_Address AS Addresss,employee.Monthly_saalary AS Salary, Admin_as.user_name AS Admin,Gender.Gender_name AS Gender,employee.Overtime_rate AS Overtime_Rate, employee.Leave_Count_Fk AS Leave, employee.Employee_WorkDays AS Workdays, employee.Allowence AS Allowence FROM Employee JOIN Admin_as ON employee.Admin_Fk = Admin_ID JOIN Gender ON employee.Gender_Fk = Gender_id JOIN Leaves_Count ON employee.Leave_Count_Fk = Leave_id ", empGridView);

        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string empid = empGridView.Rows[rowindex].Cells[0].Value.ToString();
            string sql = $"select * from employee where employee.Employee_id = '{empid}'";
            DataTable dt = Database.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                txt_EmpID.Text = dt.Rows[0]["Employee_id"].ToString();
                txt_EmpName.Text = dt.Rows[0]["Employee_name"].ToString();
                txt_EmpAdd.Text = dt.Rows[0]["Employee_Address"].ToString();
                txt_EmpMobNumber.Text = dt.Rows[0]["Employee_mobile"].ToString();
                txt_EmpMonthSal.Text = dt.Rows[0]["Monthly_saalary"].ToString();
                comBox_AdminFk.SelectedValue = dt.Rows[0]["Admin_Fk"].ToString() ;
                comBox_GenderFk.SelectedValue = dt.Rows[0]["Gender_Fk"].ToString();
                txt_EmpOverTimeRate.Text = dt.Rows[0]["Overtime_rate"].ToString();
                comBox_LeaveCountFk.SelectedValue = dt.Rows[0]["Leave_Count_Fk"].ToString();
                txt_EmpWorkDays.Text = dt.Rows[0]["Employee_WorkDays"].ToString();
                txt_EmpAllowence.Text = dt.Rows[0]["Allowence"].ToString(); 
            }
        }

        private void btuUpdate_Click(object sender, EventArgs e)

        {   
            string sql = $"update employee set Employee_name = '{txt_EmpName.Text}', Employee_Address = '{txt_EmpAdd.Text}', Employee_mobile = '{txt_EmpMobNumber.Text}', Monthly_saalary = '{txt_EmpMonthSal.Text}', Admin_Fk = '{comBox_AdminFk.SelectedValue.ToString()}', Gender_Fk = '{comBox_GenderFk.SelectedValue.ToString()}',Overtime_rate = '{txt_EmpOverTimeRate.Text}', Leave_Count_Fk = '{comBox_LeaveCountFk.SelectedValue.ToString()}', Employee_WorkDays = '{txt_EmpWorkDays.Text}',Allowence = '{txt_EmpAllowence.Text}'   where Employee_id = '{txt_EmpID.Text}'";
            Database.update(sql);
            loadtabTableFunction();
        }

        private void btuDelete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from employee where Employee_id = '{txt_EmpID.Text}'";
            Database.delete(sql);
            loadtabTableFunction();
        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            {
                Commom_class.clearInputs(new List<Control>()
            {
                txt_EmpID,
                txt_EmpName,
                txt_EmpAdd,
                txt_EmpMobNumber,
                txt_EmpMonthSal,
                comBox_AdminFk,
                comBox_GenderFk,
                comBox_LeaveCountFk,
                txt_EmpOverTimeRate,
                txt_EmpWorkDays,
                txt_EmpAllowence

         });

            }
        }

        private void btuSave_Click(object sender, EventArgs e)
        {
            string emp_id = txt_EmpID.Text;
            string empl_Name = txt_EmpName.Text;
            string empl_address = txt_EmpAdd.Text;
            string empl_mobile = txt_EmpMobNumber.Text;
            string month_salary = txt_EmpMonthSal.Text;
            string adminFK = comBox_AdminFk.SelectedValue.ToString();
            string gender = comBox_GenderFk.SelectedValue.ToString();
            string ovefrtiemRate = txt_EmpOverTimeRate.Text;
            string leaveFk = comBox_LeaveCountFk.SelectedValue.ToString();
            string empl_WorkDays = txt_EmpWorkDays.Text;
            string allowence = txt_EmpAllowence.Text;

            string sql = $"INSERT INTO employee (Employee_name,Employee_Address,Employee_mobile,Monthly_saalary,Admin_Fk,Gender_Fk,Overtime_rate,Leave_Count_Fk,Employee_WorkDays,Allowence) VALUES ('{empl_Name}','{empl_address}','{empl_mobile}','{month_salary}','{adminFK}','{gender}','{ovefrtiemRate}','{leaveFk}','{empl_WorkDays}','{allowence}' )";
            Database.save(sql);
            loadtabTableFunction();
        }
    }
}
