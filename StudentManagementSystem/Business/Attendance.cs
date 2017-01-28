using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Business
{
    class Attendance
    {

        private string Student_Id;
        private string Date;
        private string Course_Id;
        private string Batch_Id;
        private string TimeIn;
        private string TimeOut;
       

        public string student_Id  
        {
            set { this.Student_Id = value; }
            get { return this.Student_Id; }
        }


        public string date
        {
            set { this.Date = value; }
            get { return this.Date; }
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


        public string timeIn
        {
            set { this.TimeIn = value; }
            get { return this.TimeIn; }
        }


        public string timeOut
        {
            set { this.TimeOut = value; }
            get { return this.TimeOut; }
        }



    /*    public Attendance() { }//Default constructor

        public Attendance(string sid)
        {
            this.student_Id = sid; //custom constructor
        }

        public Attendance(string sid, string date, string courid, string batchid, string tmin, string tmout)
        {
            this.Student_Id = sid;
            this.Date = date;
            this.Course_Id = courid;
            this.Batch_Id = batch_Id;
            this.TimeIn = tmin;
            this.TimeOut = tmout;
           
           
        }


        public List<Attendance> getAllStudents()
        {
            string query = "select * from Attendance";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            List<Attendance> AttendanceList = new List<Attendance>();
            while (reader.Read())
            {
                AttendanceList.Add(new Attendance(reader["Student_Id"].ToString(), reader["Date"].ToString(), reader["Course_Id"].ToString(), reader["Batch_Id"].ToString(), reader["TimeIn"].ToString(), reader["TimeOut"].ToString()));
            }
            return AttendanceList;

        }*/

       

    }
}
