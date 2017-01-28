using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentManagementSystem.Business;
using StudentManagementSystem.Database;
using StudentManagementSystem.Presentation;

namespace StudentManagementSystem.Presentation.Student   
{
    public partial class frmStudent_Registration : Form
    {

        private StudentManagementSystem.Business.StudentManagement studMgmnt;
        private StudentInfo studInfo = new StudentInfo();


        public frmStudent_Registration()

        {
            InitializeComponent();
        }

        private void frmStudent_Registration_Load(object sender, EventArgs e)
        {
            studMgmnt = new StudentManagementSystem.Business.StudentManagement();
            studInfo = new StudentInfo();

        }
        

        public void btnRegister_Click(object sender, EventArgs e)
        {

            if (this.isvalidate())   
            {
                
                this.studInfo.Student_FullName = txtStudentFName.Text;
                this.studInfo.DOB = dateTimePickerDOB.Text;
                this.studInfo.Student_Address = txtAddress.Text;
                this.studInfo.Mobile_Number = txtPhoneNo.Text;
                this.studInfo.Land_Number = txtLandPhoneNo.Text;
                this.studInfo.Gender = cmbGender.SelectedValue.ToString();
                this.studInfo.Email = txtEmail.Text;
                this.studInfo.NIC = txtNIC.Text;
                this.studInfo.Guardian_Name = txtGuardianName.Text;
                this.studInfo.Course_Id = cmbCourseId.SelectedValue.ToString();
                this.studInfo.Course_Name = cmbCourseName.SelectedValue.ToString();
                this.studInfo.Batch_Id = cmbBatchId.SelectedValue.ToString();
                this.studInfo.Registration_Date = dateTimePickerRegisteredDate.Text;
                int flag = studMgmnt.Insert_studentDetails(this.studInfo);
                if (flag == 1)
                {
                    MessageBox.Show("Successfully Inserted");
                    btnClear_Click(sender, e);
                
                }

                else if (flag == 2)
                {
                    MessageBox.Show("Duplicate User Cannot Inserted");
  
                }
                else
                    MessageBox.Show("Data Error");
            }


            }


        private bool isvalidate()
        {
            bool state = true;
            string msglist = "";

            if (txtStudentFName.Text == "" || txtStudentFName.Text == txtStudentFName.Tag.ToString())
            {
                msglist = "Enter Student Details\r\n";

            }
            if (txtAddress.Text == "" || txtAddress.Text == txtAddress.Tag.ToString())
            {
                msglist = msglist + "Enter Student Address\r\n";

            }
            if (txtPhoneNo.Text == "" || txtPhoneNo.Text == txtPhoneNo.Tag.ToString())
            {
                msglist = msglist + "Enter Student Contact No\r\n";

            }
            if (txtGuardianName.Text == "" || txtGuardianName.Text == txtGuardianName.Tag.ToString())
            {
                msglist = msglist + "Enter Guardian Person Name\r\n";

            }
            if (msglist != "")
            {
                state = false;
                MessageBox.Show(msglist);
            }
            else
                state = true;
            return state;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentFName.Clear();
           // dateTimePickerDOB
            txtAddress.Clear();
            txtPhoneNo.Clear();
            txtLandPhoneNo.Clear();
          //  cmbGender.SelectedValue.ToString();
            txtEmail.Clear();
            txtNIC.Clear();
            txtGuardianName.Clear();
            //cmbCourseId.SelectedValue.ToString();
          //  cmbCourseName.SelectedValue.ToString();
           // cmbBatchId.SelectedValue.ToString();
           // dateTimePickerRegisteredDate.Text;
        }


        SqlConnection con = new SqlConnection("Data Source=ACER;Initial Catalog=StudentManagementSystem;Integrated Security=True");

        string imageLocation = "";
        SqlConnection cmd;
        
        
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {

        }

        



        

    }
}
