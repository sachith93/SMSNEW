using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using StudentManagementSystem.Business;
using System.Windows.Forms;

namespace StudentManagementSystem.Business
{
    public class UserRoleControl : ConnectionAccessClass
    {
        private ConnectionAccessClass ConAcsClz;
       public static bool isDuplicate;
       public static bool isForeignKey;

        public bool CheckUserRoleExit(string role)
        {
            DataTable dt = FillDataSet("select * from User_Role where User_Role='" + role + "'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
                return true;
        }

        public bool InsertNewUserRole( string name)
        {
            bool val = new_insert_update_command("insert into User_Role(RoleName)  values('" + name + "')");
            return val;
        }
        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Alart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public DataSet Get_all_roles()
        {
            DataSet ds = FillDataSet("select ur.* from User_Role as ur order by id asc");
            return ds;
        }
    }
}
