using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace StudentManagementSystem.Database
{
    public class DatabaseConnection
    {
        public static bool isDuplicate;
        public static bool isForignKey;

        public static SqlConnection dbconnection()
        {
            SqlConnection con = new SqlConnection("Data Source=ACER;Initial Catalog=StudentManagementSystem;Integrated Security=True");
            con.Open();
            return con;
        }



        public bool new_Insert_Update_Command(string command)
        {
            isDuplicate = false;
            bool flag = false;
            SqlConnection con = null;
            SqlCommand com = null;
            try
            {
                con = dbconnection();
                con.Open();
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
        public DataSet FillDataSet(string select)
        {
            DataSet dataset = new DataSet();
            SqlConnection con = null;
            SqlCommand com = null;
            try
            {
                con = dbconnection();
                con.Open();
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

        internal SqlDataReader executeQuery(string query)
        {
            throw new NotImplementedException();
        }

        internal bool executeNonQuery(string query)
        {
            throw new NotImplementedException();
        }
    }
}