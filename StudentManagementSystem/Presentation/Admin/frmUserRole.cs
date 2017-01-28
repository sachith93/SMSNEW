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
    public partial class frmUserRole : Form
    {
        UserRoleControl userRoleCntrol;
        public frmUserRole()
        {

            InitializeComponent();
        }

        private void frmUserRole_Load(object sender, EventArgs e)
        {
            this.DataBindGrid();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (txtUserRoleName.Text != null && txtUserRoleName.Text != "")
            {
                if (userRoleCntrol.CheckUserRoleExit(txtUserRoleName.Text))
                {
                    if (userRoleCntrol.InsertNewUserRole(txtUserRoleName.Text))
                    {
                        txtUserRoleName.Text = "";
                        ShowMessage("User Role Inserted");
                        this.DataBindGrid();
                    }
                    else
                        ShowMessage("ERROR DATA");
                }
                else
                    ShowMessage("The User Role Exists");
            }
            else
            {
                ShowMessage("Role name cannot be a null.");
                txtUserRoleName.Focus();

            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Alart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void DataBindGrid()
        {
            DataTable table = userRoleCntrol.Get_all_roles().Tables[0];
            gridRole.DataSource = table;
        }
    }
}

       