using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Grifindo_Toys.Class
{
    internal class Database
    {
        // database config
        private static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IEPCDN4\SQLEXPRESS;Initial Catalog=GrifindoToys;Integrated Security=True");

        // save
        public static bool save(string sql)
        {
            bool status = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Data inserted Successfully");
                    status = true;
                }
                else
                {
                    MessageBox.Show("contact with your IT Department");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }


        public static bool update(string sql)
        {
            bool status = false;
            try
            {
                if (MessageBox.Show("Do you want to update ? ", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Data updated");
                        status = true;
                    }
                    else
                    {
                        MessageBox.Show("Contact with your IT Department");
                    }
                }


            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return status;

        }




        public static bool delete(string sql)
        {
            bool status = false;
            try
            {
                if(MessageBox.Show("Do you want to Delete ?", "Delete Confirmation Message",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Data Deleted");
                        status = true;
                    }
                    else
                    {
                        MessageBox.Show("Contact with your IT Department");
                    }
                }
               
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public static void loadDataFromDBtoDataGridView(string sql, DataGridView loadTable)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                loadTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void loadFkDataInComboBox(string sql, ComboBox fkBox, string idColumnName, string nameColumnName)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fkBox.ValueMember = idColumnName;
            fkBox.DisplayMember = nameColumnName;
            fkBox.DataSource = dt;
        }
        public static DataTable getDataFromDB(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
