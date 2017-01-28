using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagementSystem.Business
{
    public class UserInfo
    {
        private int user_id;
        private string u_name;
        private string password;
        private string user_role;
        private string role_Id;
        private string is_active;
        


        public int User_Id
        {
            set { user_id = value; }
            get { return user_id; }
        }

        public string UName
        {
            set { u_name = value; }
            get { return u_name; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }
      

        public string User_role
        {
            set { user_role = value; }
            get { return user_role; }
        }
       
        public string Role_Id
        {
            set { role_Id = value; }
            get { return role_Id; }
        }

        public string Status
        {
            set { is_active = value; }
            get { return is_active; }
        }
    }
}
