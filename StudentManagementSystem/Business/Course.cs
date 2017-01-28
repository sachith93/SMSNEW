using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Business
{
    class Course  
    {

        private string Course_Id;
        private string Course_Name;
        private string Lecturer_Id;
       

        public string course_Id
        {
            set { this.Course_Id = value; }
            get { return this.Course_Id; }
        }


        public string course_Name
        {
            set { this.Course_Name = value; }
            get { return this.Course_Name; }
        }


        public string lecturer_Id
        {
            set { this.Lecturer_Id = value; }
            get { return this.Lecturer_Id; }
        }
       



       /* public Course() { }//Default constructor

        public Course(string cid)
        {
            this.course_Id = cid; //custom constructor
        }

        public Course(string cid, string courname, string lectrid)
        {
            this.Course_Id = cid;
            this.Course_Name = courname;
            this.Lecturer_Id = lectrid;
           
        }


        public List<Course> getAllCourses()
        {
            string query = "select * from Course";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            List<Course> CourseList = new List<Course>();
            while (reader.Read())
            {
                CourseList.Add(new Course(reader["course_Id"].ToString(), reader["Course_Name"].ToString(), reader["Lecturer_Id"].ToString()));
            }
            return CourseList;

        }*/

       

    }
}
