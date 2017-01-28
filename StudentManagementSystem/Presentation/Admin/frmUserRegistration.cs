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
    public partial class frmUserRegistration : Form
    {
        private StudentManagementSystem.Business.UserManagement uMgmnt;
        private UserInfo uInfo;

        public frmUserRegistration()
        {
            InitializeComponent();
        }

       
        private void frmUserRegistration_Load(object sender, EventArgs e)
        {
            uMgmnt = new StudentManagementSystem.Business.UserManagement();
            uInfo = new UserInfo();
            cmbUserRole.DataSource = uMgmnt.Set_role_dropdown();
            cmbUserRole.DisplayMember = "Role_Name";
            cmbUserRole.ValueMember = "Role_Id";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (this.isvalidate())
            {                
                this.uInfo.UName = txtUserName.Text;
                this.uInfo.Role_Id = cmbUserRole.SelectedValue.ToString();
                this.uInfo.Password = txtPassword.Text;
                this.uInfo.Status ="Active";
                
                int flag = uMgmnt.Insert_user(this.uInfo);
                if (flag == 1)
                {
                    MessageBox.Show("Succussfuly Inserted");
                }
                else if (flag == 2)
                {
                    MessageBox.Show("Duplicate User Cannot Inserted");
                }
                else
                    MessageBox.Show("DATA ERROR");
            }
        }

     private bool isvalidate()
        {
            bool state = true;

            List<string> msglist = new List<string>();

            if (txtUserName.Text == "" || txtPassword.Text == "" )
            {
                msglist.Add("Enter User Name and Password");
                state = false;
            }
            else
            {
                state = true;
            }
            return state;
        }

     private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
     {

     }

     private void btnUpdate_Click(object sender, EventArgs e)
     {

     }

     private void btnDelete_Click(object sender, EventArgs e)
     {

     }

     private void btnExit_Click(object sender, EventArgs e)
     {
         this.Close();
     }


        // textbox validation controls
         void ValidateTextBoxForInt( object sender, EventArgs e)
         {
          TextBox txt = ( TextBox) sender;
           if (txt.Text != "")
           {
             String newVal = "";
             foreach (char c in txt.Text)
               {
                   if (!char.IsDigit(c))
                     {
                        break;
                     }
                       else
                         {
                            newVal = newVal + c.ToString();
                         }

                       }

                           txt.Text = newVal;
                           txt.Select(newVal.Length, newVal.Length);
                       }
                    }
        
        




  
       
    }
}
