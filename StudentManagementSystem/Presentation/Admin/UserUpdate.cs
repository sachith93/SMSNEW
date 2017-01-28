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
    public partial class UserUpdate : Form
    {
        private int userId;
        private StudentManagementSystem.Business.UserManagement uMgmnt;
        private UserInfo uInfo;
        public UserUpdate()
        {
            InitializeComponent();
        }

        public UserUpdate(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void UserUpdate_Load(object sender, EventArgs e)
        {
            uMgmnt = new StudentManagementSystem.Business.UserManagement();
            uInfo = new UserInfo();
            cmbUserRole.DataSource = uMgmnt.Set_role_dropdown();
            cmbUserRole.DisplayMember = "Role_Name";
            cmbUserRole.ValueMember = "Role_Id";
            uInfo = uMgmnt.SelectUserDetailsUsingUserID(this.userId);
            this.LoadAllControls();
        }

        private void LoadAllControls()
        {
            txtUserName.Text = uInfo.UName;
            cmbStatus.Text = uInfo.Status;
            //cmbUserRole.SelectedValue = uInfo.Role_Id;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserInfo editedUInfo = new UserInfo();
            editedUInfo.UName = txtUserName.Text.ToString();
            editedUInfo.Password = txtPassword.Text;
            editedUInfo.Role_Id = cmbUserRole.SelectedValue.ToString();
            editedUInfo.Status = cmbStatus.Text;
            editedUInfo.User_Id = this.userId;
            int flag = uMgmnt.UpdateUserDetailsUsingUserID(editedUInfo);
            if (flag == 1)
            {
                MessageBox.Show("Succsessfully Updated..!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int User_Id = this.userId;
            int flag = uMgmnt.DeleteUserDetailsUsingUserID(User_Id);
            if (flag == 1)
            {
                MessageBox.Show("Succsessfully Deleted..!!");
            }
        }
    }
}
