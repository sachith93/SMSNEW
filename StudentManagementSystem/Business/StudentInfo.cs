using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagementSystem.Business
{
    public class StudentInfo
    {

        private int student_Id;
        private string student_FullName;
        private string dOB;
        private string student_Address;
        private string mobile_Number;
        private string land_Number;
        private string gender;
        private string email;
        private string photo;
        private string nIC;
        private string guardian_Name;
        private string course_Id;
        private string course_Name;
        private string batch_Id;
        private string registration_Date;

        

        public int Student_Id
        {
            set { this.student_Id = value; }
            get { return this.student_Id; }
        }

       
        public string Student_FullName
        {
            set { this.student_FullName = value; }
            get { return this.student_FullName; }
        }
        public string DOB
        {
            set { this.dOB = value; }
            get { return this.dOB; }
        }
        public string Student_Address
        {
            set { this.student_Address = value; }
            get { return this.student_Address; }
        }
        public string Mobile_Number
        {
            set { this.mobile_Number = value; }
            get { return this.mobile_Number; }
        }
        public string Land_Number
        {
            set { this.land_Number = value; }
            get { return this.land_Number; }
        }
         public string Gender
        {
            set { this.gender = value;}
            get { return this.gender; }
        }

         public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public string Photo
        {
            set { this.photo = value; }
            get { return this.photo; }
        }
        public string NIC
        {
            set { this.nIC = value; }
            get { return this.nIC; }
        }
        public string Guardian_Name
        {
            set { this.guardian_Name = value; }
            get { return this.guardian_Name; }
        }
        public string Course_Id
        {
            set { this.course_Id = value; }
            get { return this.course_Id; }
        }
        public string Course_Name
        {
            set { this.course_Name = value; }
            get { return this.course_Name; }
        }
        public string Batch_Id
        {
            set { this.batch_Id = value; }
            get { return this.batch_Id; }
        }
        public string Registration_Date
        {
            set { this.registration_Date = value; }
            get { return this.registration_Date; }
        }










        /* public StudentInfo () { }//Default constructor

         public StudentInfo(int sid)
         {
             this.student_Id = sid; //custom constructor
         }

         public StudentInfo (int sid, string sfullname, string dob, string sadrs,  string smobi,  string sland, string sgender, string eml, string pho, string nic, string gurdname, string couid, string cousnm, string batid, string regdate)
         {
             this.Student_Id = sid;
             this.Student_FullName = sfullname;
             this.DOB = dob;
             this.Student_Address = sadrs;
             this.Mobile_Number = smobi;
             this.Land_Number = sland;
             this.Gender = sgender;
             this.Email = email;
             this.photo = pho;
             this.NIC = nic;
             this.Guardian_Name = gurdname;
             this.Course_Id = couid;
             this.Course_Name = cousnm;
             this.Batch_Id = batid;
             this.Registration_Date =regdate;
         }*/


       /* public List<StudentInfo> getAllStudents()
        {
            string query = "select * from Student";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            List<StudentInfo> studentList = new List<StudentInfo>();
            while (reader.Read())
            {
                studentList.Add(new StudentInfo (reader["Student_Id"].ToString(), reader["Student_FullName"].ToString(), reader["DOB"].ToString(), reader["Student_Address"].ToString(), reader["Mobile_Number"].ToString(), reader["Land_Number"].ToString(), reader["Gender"].ToString(), reader["Email"].ToString(), reader["Photo"].ToString(), reader["NIC"].ToString(), reader["Guardian_Name"].ToString(), reader["Course_Id"].ToString(), reader["Course_Name"].ToString(), reader["Batch_Id"].ToString(), reader["Registration_Date"].ToString()));
            }
            return studentList;
        
        }

        public bool insertStudent()
        {
            string query = "exec insertStudent '" + this.Student_Id  + "','" + this.Student_FullName + "'," + this.DOB + ",'" + this.Student_Address + "'," + this.Mobile_Number +"'," + this.Land_Number +"','" + this.Gender  + "','" + this.Email  + "','" + this.Photo  + "','" + this.NIC  + "','" + this.Guardian_Name  + "','" + this.Course_Id  + "','" + this.Course_Name  + "','" + this.Batch_Id  + "','" + this.Registration_Date  + "'";
           
            return new DataAccessConnection().executeNonQuery(query);
        }

        public bool updateStudent()
        {
            string query = "exec updateStudent '" + this.Student_Id  + "','" + this.Student_FullName + "'," + this.DOB + ",'" + this.Student_Address + "'," + this.Mobile_Number +"'," + this.Land_Number +"','" + this.Gender  + "','" + this.Email  + "','" + this.Photo  + "','" + this.NIC  + "','" + this.Guardian_Name  + "','" + this.Course_Id  + "','" + this.Course_Name  + "','" + this.Batch_Id  + "','" + this.Registration_Date  + "',";
            return new DataAccessConnection().executeNonQuery(query);
        }

        public bool deleteStudent()
        {
            string query = "exec deleteStudent '" + this.Student_Id  + "','" + this.Student_FullName + "'," + this.DOB + ",'" + this.Student_Address + "'," + this.Mobile_Number +"'," + this.Land_Number +"','" + this.Gender  + "','" + this.Email  + "','" + this.Photo  + "','" + this.NIC  + "','" + this.Guardian_Name  + "','" + this.Course_Id  + "','" + this.Course_Name  + "','" + this.Batch_Id  + "','" + this.Registration_Date  + "',";
            return new DataAccessConnection().executeNonQuery(query);
        }

        public StudentInfo findStudent (string sid)
        {
            string query = "exec getCompleteStudentDetailById '" + this.Student_Id + "'";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            StudentInfo stuobj = null;
            if (reader.Read())
            {
                stuobj = new StudentInfo(reader["Student_Id"].ToString(),reader["Student_FullName"].ToString(),reader["DOB"].ToString(),reader["Student_Address"].ToString(),reader["Mobile_Number"].ToString(),reader["Land_Number"].ToString(),reader["Gender"].ToString(),reader["Email"].ToString(),reader["Photo"].ToString(),reader["NIC"].ToString(),reader["Guardian_Name"].ToString(),reader["Course_Id"].ToString(),reader["Course_Name"].ToString(),reader["Batch_Id"].ToString(), reader["Registration_Date"].ToString());
            }

            return stuobj;
        }*/

    }
}
