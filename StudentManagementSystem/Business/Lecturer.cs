using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Business
{
    class Lecturer  
    {

        private string Lecturer_Id;
        private string Lecturer_FName;
        private string Lecturer_LName;
        private string DOB;
        private string Address;
        private string Mobile_Number;
        private string Gender;
        private string Email;
        private string NIC;
        private string Course_Id;
        private string Batch_Id; 
        private string Photo;
        

        public string lecturer_Id
        {
            set { this.Lecturer_Id = value; }
            get { return this.Lecturer_Id; }
        }


        public string lecturer_FName
        {
            set { this.Lecturer_FName = value; }
            get { return this.Lecturer_FName; }
        }
        public string lecturer_LName
        {
            set { this.Lecturer_LName = value; }
            get { return this.Lecturer_LName; }
        }
        public string dOB
        {
            set { this.DOB = value; }
            get { return this.DOB; }
        }
        public string address
        {
            set { this.Address = value; }
            get { return this.Address; }
        }
        public string mobile_Number
        {
            set { this.Mobile_Number = value; }
            get { return this.Mobile_Number; }
        }
        public string gender
        {
            set { this.Gender = value; }
            get { return this.Gender; }
        }

        public string email
        {
            set { this.Email = value; }
            get { return this.Email; }
        }
        public string photo
        {
            set { this.Photo = value; }
            get { return this.Photo; }
        }
        public string nIC
        {
            set { this.NIC = value; }
            get { return this.NIC; }
        }
      
        public string course_Id
        {
            set { this.Course_Id = value; }
            get { return this.Course_Id; }
        }
       
        public string batch_Id
        {
            set { this.Batch_Id = value; }
            get { return this.Batch_Id; }
        }
        



        public Lecturer() { }//Default constructor

        public Lecturer(string lid)
        {
            this.lecturer_Id =lid;         //custom constructor
        }

        public Lecturer(string lid, string lfname, string llname, string dob, string ladres, string lmobi, string gendr, string emal, string nic, string courid, string batchid, string photo)
        {
            this.Lecturer_Id = lid;
            this.Lecturer_FName = lfname;
            this.Lecturer_LName = llname;
            this.DOB = dob;
            this.Address = ladres;
            this.Mobile_Number = lmobi;
            this.Gender = gender;
            this.Email = email;
            this.NIC = nic;
            this.Course_Id = courid;
            this.Batch_Id = batch_Id;
            this.Photo = photo;
           
        }

      
      /*  public List<Lecturer> getAllLecturers()
        {
            string query = "select * from Lecturer";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            List<Lecturer> lecturerList = new List<Lecturer>();
            while (reader.Read())
            {
                lecturerList.Add(new Lecturer(reader["Lecturer_Id"].ToString(), reader["Lecturer_FName"].ToString(), reader["Lecturer_LName"].ToString(), reader["DOB"].ToString(), reader["Address"].ToString(), reader["Mobile_Number"].ToString(), reader["Gender"].ToString(), reader["Email"].ToString(), reader["NIC"].ToString(), reader["Course_Id"].ToString(), reader["Batch_Id"].ToString(), reader["Photo"].ToString()));
            }
            return lecturerList;

        }

        public bool insertLecturer()
        {
            string query = "exec insertLecturer '" + this.Lecturer_Id + "','" + this.Lecturer_FName + "'," + this.Lecturer_LName + ",'" + this.DOB + "'," + this.Address + "'," + this.Mobile_Number + "','" + this.Gender + "','" + this.Email + "','" + this.NIC + "','" + this.Course_Id + "','" + this.Batch_Id + "','" + this.Course_Id + "','" + this.Photo + "'";

            return new DataAccessConnection().executeNonQuery(query);
        }

        public bool updateLecturer()
        {
            string query = "exec updateLecturer '" + this.Lecturer_Id + "','" + this.Lecturer_FName + "'," + this.Lecturer_LName + ",'" + this.DOB + "'," + this.Address + "'," + this.Mobile_Number + "','" + this.Gender + "','" + this.Email + "','" + this.NIC + "','" + this.Course_Id + "','" + this.Batch_Id + "','" + this.Course_Id + "','" + this.Photo + "'";
            return new DataAccessConnection().executeNonQuery(query);
        }

        public bool deleteLecturer()
        {
            string query = "exec deleteLecturer '" + this.Lecturer_Id + "','" + this.Lecturer_FName + "'," + this.Lecturer_LName + ",'" + this.DOB + "'," + this.Address + "'," + this.Mobile_Number + "','" + this.Gender + "','" + this.Email + "','" + this.NIC + "','" + this.Course_Id + "','" + this.Batch_Id + "','" + this.Course_Id + "','" + this.Photo + "'";
            return new DataAccessConnection().executeNonQuery(query);
        }

        public Lecturer findLecturer (string lid)
        {
            string query = "exec getCompleteLecturerDetailById '" + this.Lecturer_Id + "'";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            Lecturer lectobj = null;
            if (reader.Read())
            {
                lectobj = new Lecturer(reader["Lecturer_Id"].ToString(), reader["Lecturer_FName"].ToString(), reader["Lecturer_LName"].ToString(), reader["DOB"].ToString(), reader["Address"].ToString(), reader["Mobile_Number"].ToString(), reader["Gender"].ToString(), reader["Email"].ToString(), reader["NIC"].ToString(), reader["Course_Id"].ToString(), reader["Batch_Id"].ToString(), reader["Photo"].ToString());
            }

            return lectobj;
        }*/

    }
}
