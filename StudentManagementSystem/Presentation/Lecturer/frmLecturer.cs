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

namespace StudentManagementSystem
{
    public partial class frmLecturer : Form
    {
        public frmLecturer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ACER;Initial Catalog=StudentManagementSystem;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Lecturer ( Lecturer_Id,Lecturer_Fullname,DOB,Address,Mobile_Number,Gender,Email,Course,Image ) values ('" + txtLecturerId.Text + "','" + txtLecturerFName.Text + "','" + dateTimePickerDOB.Text + "','" + txtAddress.Text + "','" + txtMobileNo.Text + "','" + cmbGender.Text + "','" + txtEmail.Text + "','" + cmbCourse.Text + "','"+ pictureBoxLecturerImage.Text +"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Congratulation !! Record Added Successfully!!");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ACER;Initial Catalog=StudentManagementSystem;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Update Lecturer  set  Lecturer_Fullname ='" + txtLecturerFName.Text + "',DOB='" + dateTimePickerDOB.Text + "',Address='" + txtAddress.Text + "', Mobile_Number='" + txtMobileNo.Text + "', Gender='" + cmbGender.Text + "', Email='" + txtEmail.Text + "',Course='" + cmbCourse.Text + "',Image='" + pictureBoxLecturerImage.Text  + "' where (Lecturer_Id ='" + txtLecturerId.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ACER;Initial Catalog=StudentManagementSystem;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Delete from Lecturer  where (Lecturer_Id ='" + txtLecturerId.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!!");
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
