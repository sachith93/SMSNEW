using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Business
{
    class TimeTable
    {

        private string Course_Id;
        private string Cours_Name;
        private string Date;
        private string Time_Period;
        private string Class_Room;
        private string Lecturer_Id;
        private string Lecturer_Name;


        public string course_Id
        {
            set { this.Course_Id = value; }
            get { return this.Course_Id; }
        }


        public string cours_Name
        {
            set { this.Cours_Name = value; }
            get { return this.Cours_Name; }
        }


        public string date
        {
            set { this.Date = value; }
            get { return this.Date; }
        }

        public string time_Period
        {
            set { this.Time_Period = value; }
            get { return this.Time_Period; }
        }

        public string class_Room
        {
            set { this.Class_Room = value; }
            get { return this.Class_Room; }
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
    }
}
