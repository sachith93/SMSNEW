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

namespace StudentManagementSystem.Presentation.Student 
{
    public partial class frmStudentBehavier : Form
    {
        public frmStudentBehavier()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=ACER;Initial Catalog=StudentManagementSystem;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Behaviers  ( Student_Id,Student_Name,Course,Batch_Id,Special_Incident,Marked_By,Marked_Date,Behavier_Type,Load_Image ) values ('" + cmbStudentID.Text + "','" + txtStudentName.Text + "','" + cmbCourse.Text + "','" + cmbBatchNo.Text + "','" + txtSpecialIncident.Text + "','" + dateTimePicker1.Text + "','" + txtMarkedBy.Text + "','" + cmbCourse.Text + "','" + dateTimePicker2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Congratulation !! Record Added Successfully!!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

        }
    }
}
