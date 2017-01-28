using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using StudentManagementSystem.Business;
using StudentManagementSystem.Database;



namespace StudentManagementSystem.Business
{
    public class UserManagement : ConnectionAccessClass
    {
        private ConnectionAccessClass ConAcsClz;
        public static bool isDuplicate;
        public static bool isForignKey;

        public int Insert_user(UserInfo uInfo)
        {
            int flag = 0;
            bool state = false;
            try
            {
                string query = "insert into UserDetails(User_Name,Password,Role_Id,Status)values('" + uInfo.UName + "','" + uInfo.Password + "','" + uInfo.Role_Id + "', '" + uInfo.Status + " ')";
                state = new_insert_update_command(query);

                if (state)
                    flag = 1;
                else
                {
                    if (isDuplicate)
                        flag = 2;
                    else
                        flag = 0;
                }
            }
            catch (Exception)
            {
                flag = 0;
            }
            return flag;

        }

        public DataTable Set_role_dropdown()
        {
            DataTable dt = FillDataSet("select Role_Id,Role_Name from User_Role").Tables[0]; 
            DataRow r = dt.NewRow();
            r["Role_Id"] = "0";
            r["Role_Name"] = " -Select Role- ";
            dt.Rows.InsertAt(r, 0);
            return dt;
        }

        public UserInfo Select_user_by_user_name(string no)
       {
       
          UserInfo u = new UserInfo();
           try
           {
               DataTable dt = FillDataSet("select User_Name,Password,Status from UserDetails where User_Name='" + no + "'").Tables[0];
               foreach (DataRow r in dt.Rows)
               {
                  u.Password = r["Password"].ToString();
                  u.UName = r["User_Name"].ToString();
                  u.Status =r["Status"].ToString();
               }
           }
           catch (Exception e)
           {
               e.ToString();
           }
           
           return u;

       

       }
        public DataTable SelectAllUsers()
        {
            DataTable dt = FillDataSet("select * from UserDetails as u, User_Role as r where u.Role_Id=r.Role_Id;").Tables[0];
            return dt;
        }

        public UserInfo SelectUserDetailsUsingUserID(int UserID)
        {
            UserInfo u = new UserInfo();
            try
            {
                DataTable dt = FillDataSet("select * from UserDetails where UserID='" + UserID + "'").Tables[0];
                foreach (DataRow r in dt.Rows)
                {
                    u.Role_Id = r["Role_Id"].ToString();
                    u.Password = r["Password"].ToString();
                    u.UName = r["User_Name"].ToString();
                    u.Status = r["Status"].ToString();
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }

            return u;
        }

        public int UpdateUserDetailsUsingUserID(UserInfo editedUInfo)
        {
            int flag = 0;
            bool state = false;
            try
            {
                string query = "update UserDetails set User_Name='" + editedUInfo.UName + "',Password='" + editedUInfo.Password + "',Role_Id='" + editedUInfo.Role_Id + "', Status='" + editedUInfo.Status + "' where UserID='" + editedUInfo.User_Id + "';";
                state = new_insert_update_command(query);

                if (state)
                    flag = 1;
                else
                {
                    if (isDuplicate)
                        flag = 2;
                    else
                        flag = 0;
                }
            }
            catch (Exception)
            {
                flag = 0;
            }
            return flag;
        }

        public int DeleteUserDetailsUsingUserID(int User_Id)
        {
            int flag = 0;
            bool state = false;
            try
            {
                string query = "delete UserDetails where UserID='" + User_Id + "';";
                state = new_insert_update_command(query);

                if (state)
                    flag = 1;
                else
                {
                    if (isDuplicate)
                        flag = 2;
                    else
                        flag = 0;
                }
            }
            catch (Exception)
            {
                flag = 0;
            }
            return flag;
        }

        





    }
}


