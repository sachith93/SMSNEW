using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentManagementSystem.Business;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Presentation.Admin
{
    public partial class frmLogIn : Form
    {
        private StudentManagementSystem.Business.UserManagement uMgmnt;
        public frmLogIn()
        {
            InitializeComponent(); 
        }

        
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text != null && txtUserName.Text != "")
            {
                if (txtPassword.Text != null && txtPassword.Text != "")
                {
                    UserInfo u = uMgmnt.Select_user_by_user_name(txtUserName.Text);
                    if (u.UName != null)
                    {
                        if (txtPassword.Text == u.Password)
                        {
                            if (u.Status =="Active")
                            {
                                //lblMessage.Text = "Welcome! you are successfully Logged into the System";
                                frmMainUserForm frmMainUf = new frmMainUserForm();
                                frmMainUf.ShowDialog();
                                this.Close();

                            }
                            else
                            {
                                lblMessage.Text = "User Deactive by Administrator";
                                txtUserName.Focus();
                                txtUserName.SelectAll();
                            }
                        }
                        else
                        {
                            lblMessage.Text = "Invalid Password";
                            txtPassword.Focus();
                            txtPassword.SelectAll();
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Invalid User Name";
                        txtUserName.Focus();
                        txtUserName.SelectAll();
                    }
                }
                else
                {
                    lblMessage.Text = "Enter Password";
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                }
            }
            else
            {
                lblMessage.Text = "Enter User Name";
                txtUserName.Focus();
                txtUserName.SelectAll();
            }
        }

        private void frmLogIn_Load_1(object sender, EventArgs e)
        {
            uMgmnt = new UserManagement();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();


           
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

           
        }

    
   }

      
         
    
