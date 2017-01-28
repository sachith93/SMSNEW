using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Business;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Presentation.Admin
{
    public partial class ViewUser : Form
    {
        private StudentManagementSystem.Business.UserManagement uMgmnt;
        private UserInfo uInfo;
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            uMgmnt = new StudentManagementSystem.Business.UserManagement();
            DataTable dt = uMgmnt.SelectAllUsers();
            gridUser.AutoGenerateColumns = false;
            gridUser.DataSource = dt;
        }

        private void gridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = gridUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            int userId = int.Parse(value.ToString());
            if (e.ColumnIndex == 0)
            {
                StudentManagementSystem.Presentation.Admin.UserUpdate updateUser = new UserUpdate(userId);
                updateUser.Show();
            }
        }
    }
}
