using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Business
{
    class Assignment
    {

        private string Assignment_Id;
        private string Date;
        private string Lecturer_Id;
        private string Lecturer_Name;
        private string Course_Id;
        private string Batch_Id;
       

        public string assignment_Id
        {
            set { this.Assignment_Id = value; }
            get { return this.Assignment_Id; }
        }


        public string date
        {
            set { this.Date = value; }
            get { return this.Date; }
        }


        public string lecturer_Id
        {
            set { this.Lecturer_Id = value; }
            get { return this.Lecturer_Id; }
        }


        public string lecturer_Name
        {
            set { this.Lecturer_Name = value; }
            get { return this.Lecturer_Name; }
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
       


       /* public Assignment() { }//Default constructor

        public Assignment(string asignid)
        {
            this.assignment_Id = asignid; //custom constructor
        }

        public Assignment(string asignid, string asgndate, string lectrid, string lectrname, string courid, string batchid)
        {
            this.Assignment_Id = asignid;
            this.Date = asgndate;
            this.Lecturer_Id = lectrid;
            this.Lecturer_Name = lectrname;
            this.Course_Id = courid;
            this.Batch_Id = batch_Id;
           
        }


        public List<Assignment> getAllAttendance()
        {
            string query = "select * from Assignment";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            List<Assignment> AssignmentList = new List<Assignment>();
            while (reader.Read())
            {
                AssignmentList.Add(new Assignment(reader["Assignment_Id"].ToString(), reader["Date"].ToString(), reader["Lecturer_Id"].ToString(), reader["Lecturer_Name"].ToString(), reader["Course_Id"].ToString(), reader["Batch_Id"].ToString() ));
            }
            return AssignmentList;

        }


        public bool insertAssignment()
        {
            string query = "exec insertAssignment '" + this.Assignment_Id + "','" + this.Date + "'," + this.Lecturer_Id + ",'" + this.Lecturer_Name + "'," + this.Course_Id + "'," + this.Batch_Id + "'";

            return new DataAccessConnection().executeNonQuery(query);
        }



        public bool deleteAssignment()
        {
            string query = "exec deleteStudent '" + this.Assignment_Id + "','" + this.Date + "'," + this.Lecturer_Id + ",'" + this.Lecturer_Name + "'," + this.Course_Id + "'," + this.Batch_Id + "'";
            return new DataAccessConnection().executeNonQuery(query);
        }

        public Assignment findAssignment(string asignid)
        {
            string query = "exec getCompleteAssignmentfilesById '" + this.Assignment_Id + "'";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            Assignment asObj  = null;
            if (reader.Read())
            {
                asObj = new Assignment(reader["Assignment_Id"].ToString(), reader["Date"].ToString(), reader["Lecturer_Id"].ToString(), reader["Lecturer_Name"].ToString(), reader["Course_Id"].ToString(), reader["Batch_Id"].ToString());
            }

            return asObj;

        
        }*/

    }
}
