using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using StudentManagementSystem.Business;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Business
{

    public class ConnectionAccessClass  
    {
        public static bool isDuplicate;
        public static bool isForignKey;
        public static string ErrorMessage { set; get; }
        public bool new_insert_update_command(string command)
        {
            isDuplicate = false;
            bool flag = false;
            SqlConnection con = null;
            SqlCommand com = null;
            try
            {
                con = DatabaseConnection.dbconnection();
                com = new SqlCommand(command, con);
                com.ExecuteNonQuery();
                flag = true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 1062)
                {
                    isDuplicate = true;
                }

                else if (ex.Number == 1452)
                    isForignKey = true;
                flag = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            return flag;
        }


        public DataSet FillDataSet(string select)  // create DataSet to select query
        {
            DataSet dataset = new DataSet();
            SqlConnection con = null;
            SqlCommand com = null;
            try
            {
                con = DatabaseConnection.dbconnection();
                com = new SqlCommand(select, con);
                com.CommandTimeout = 1800;
                SqlDataAdapter data_adapter = new SqlDataAdapter(com);
                data_adapter.Fill(dataset);
                data_adapter.Dispose();

                con.Close();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                //ErrorMessage = e.Message;
            }
            return dataset;

        }
        public DataTable dataTable(string query)
        {
            DataTable table = new DataTable();
            SqlConnection con = null;
            con = DatabaseConnection.dbconnection();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            adapter.Fill(table);
            con.Close();

            return table;
        }


        public void ValidateTextBoxForInt(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text != "")
            {
                string newVal = "";
                foreach (char c in t.Text)
                {

                    if (!Char.IsDigit(c))
                    {
                        break;
                    }
                    else
                    {
                        newVal = newVal + c.ToString();
                    }


                }


                t.Text = newVal;
                t.Select(newVal.Length, newVal.Length);
            }
        }
        public void ShowSuccessMessage()
        {
            MessageBox.Show("Successfully Inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void showUpdateSuccessMsg()
        {
            MessageBox.Show("Successfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static DataSet FillDataSetWithOutClosingConnection(string select, SqlConnection con)
        {
            DataSet dataset = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                data_adapter.Fill(dataset);
                data_adapter.Dispose();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dataset;

        }

        public static int ExecuteUpdateNonQueryAndReturnIndex(string sql, SqlConnection connection, SqlTransaction transaction)
        {
            int modified = 0;
            bool state = false;
            int id = 0;
            try
            {

                SqlCommand command = new SqlCommand(sql, connection, transaction);
                // command.ExecuteNonQuery();
                modified = (int)command.ExecuteScalar();
                // if (rowAffected > 0)
            }
            catch (SqlException ex)
            {
                if (ex.Number == 1062)
                    isDuplicate = true;
                state = false;
            }
            catch (Exception e)
            {
                state = false;
            }

            return modified;
        }

        public static bool ExecuteUpdateNonQuery(string sql, SqlConnection connection, SqlTransaction transaction)
        {
            bool status = false;
            isDuplicate = false;
            isForignKey = false;
            try
            {

                SqlCommand command = new SqlCommand(sql, connection, transaction);
                int rowAffected = command.ExecuteNonQuery();
                // if (rowAffected > 0)
                status = true;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                status = false;
                if (ex.Number == 1062)
                {
                    isDuplicate = true;
                }
                else if (ex.Number == 1452)
                    isForignKey = true;

            }

            return status;
        }





    }
}

