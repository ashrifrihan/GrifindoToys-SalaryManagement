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
    public partial class salaryColculation : Form
    {
        public salaryColculation()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit");
            Application.Exit();
            
        }

        private void btuFind_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT e.Employee_id, e.Employee_name, e.Monthly_saalary, e.Allowence, e.Overtime_rate,(SELECT COUNT(*) FROM Employee_Attendance ea WHERE ea.Employee_FK = e.Employee_id AND ea.In_time BETWEEN '{datestart_datePicker.Text}' AND '{dateEnd_datePicker.Text}') AS WorkingDays,(SELECT SUM(DATEDIFF(HOUR, ea.In_time, ea.Out_time)) FROM Employee_Attendance ea WHERE ea.Employee_FK = e.Employee_id AND ea.In_time BETWEEN '{datestart_datePicker.Text}' AND '{dateEnd_datePicker.Text}') AS WorkingHours,(SELECT SUM(h.count_of_Holidays) FROM No_of_holiday h WHERE h.months BETWEEN '{datestart_datePicker.Text}' AND '{dateEnd_datePicker.Text}') AS TotalHoliday,(SELECT SUM(DATEDIFF(DAY, al.Start_Leave_Date, al.End_Leave_Date)) FROM Applied_Leaves al WHERE al.Employee_Fk = e.Employee_id AND al.Start_Leave_Date BETWEEN '{datestart_datePicker.Text}' AND '{dateEnd_datePicker.Text}') AS Applied_leave,(SELECT s.Salary_cycle_durations FROM Setting s WHERE s.Setting_id = '1') AS Salary_cycle_durations,(COALESCE((SELECT s.Salary_cycle_durations FROM Setting s WHERE s.Setting_id = '1'), 0) - COALESCE((SELECT COUNT(*) FROM Employee_Attendance ea WHERE ea.Employee_FK = e.Employee_id AND ea.In_time BETWEEN '{datestart_datePicker.Text}' AND '{dateEnd_datePicker.Text}'), 0) - COALESCE((SELECT COUNT(*) FROM Employee_Attendance ea WHERE ea.Employee_FK = e.Employee_id AND ea.In_time BETWEEN '{datestart_datePicker.Text}' AND '{dateEnd_datePicker.Text}'), 0) - COALESCE((SELECT SUM(h.count_of_Holidays) FROM No_of_holiday h WHERE h.months BETWEEN '{datestart_datePicker.Text}' AND '{dateEnd_datePicker.Text}'), 0)) AS AbsentDays FROM Employee e WHERE e.Employee_id = '{txt_EmpID.Text}';";
            DataTable dt = Database.getDataFromDB(sql);
            if (dt.Rows.Count == 1)
            {
                int EmplID = Convert.ToInt32(dt.Rows[0]["Employee_id"].ToString());
                string EmplName = dt.Rows[0]["Employee_name"].ToString();
                float monthsalary = float.Parse(dt.Rows[0]["Monthly_saalary"].ToString());
                float allowence = float.Parse(dt.Rows[0]["Allowence"].ToString());
                int holiday = Convert.ToInt32(dt.Rows[0]["TotalHoliday"].ToString());
                float leave = float.Parse(dt.Rows[0]["Applied_leave"].ToString());
                float Salary_cycle_durations = float.Parse(dt.Rows[0]["Salary_cycle_durations"].ToString());
                int workDay = Convert.ToInt32(dt.Rows[0]["WorkingDays"].ToString());
                float WorkHours = float.Parse(dt.Rows[0]["WorkingHours"].ToString());

                float actualWorkHours = (Salary_cycle_durations * 8);
                float overtineHours = (actualWorkHours - WorkHours);
                float absentDays = (Salary_cycle_durations - workDay - leave - holiday);
                float totalSalary = (monthsalary + allowence);
                float salaryParlour = ( totalSalary / Salary_cycle_durations); 
                float nopay = ( salaryParlour * absentDays);
                float _govermentTex = 0.2f;
                float overTimerateHour = 250;



                empId.Text = EmplID.ToString();
                emp_name.Text = EmplName.ToString();
                txt_monthsal.Text = monthsalary.ToString();
                txt_allowence.Text = allowence.ToString();
                txt_holiday.Text = holiday.ToString();
                txt_leaveStart.Text = leave.ToString();
                txt_Salary_cycle_durations.Text = Salary_cycle_durations.ToString();
                txt_Workday.Text = workDay.ToString();
                txt_WorkHours.Text = WorkHours.ToString();
                txt_monthsalry2.Text = totalSalary.ToString();
                Txt_nopay.Text = nopay.ToString();
                txt_absentDays.Text = absentDays.ToString();

                if (overtineHours > 0)
                {
                    float Overtimepayment = (overtineHours * overTimerateHour);
                    float basepay = totalSalary + Overtimepayment;
                    txt_base.Text = Convert.ToString(totalSalary + Overtimepayment);
                    float grossPay = basepay - (nopay + (basepay * _govermentTex));
                    txt_Gross.Text = grossPay.ToString();
                }
                else
                {
                    txt_base.Text = totalSalary.ToString();
                    float basepay = totalSalary;
                    float grosspay = basepay - (nopay + (totalSalary * _govermentTex));
                    txt_Gross.Text = grosspay.ToString();
                }
            }

            else
            {
                MessageBox.Show("Invalid employee Id");
            }
            
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Succeses Full");

        }
    }
}
