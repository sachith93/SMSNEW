using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using StudentManagementSystem.Database;


namespace StudentManagementSystem.Business
{
    class Behaviers
    {

        private string Student_Id;
        private string Student_Name;
        private string Course_Id;
        private string Batch_Id;
        private string Special_Incident;
        private string Marked_By;
        private string Marked_Date;
        private string Behavier_Type;
        private string Load_Photo; 
        

        public string student_Id
        {
            set { this.Student_Id = value;}
            get { return this.Student_Id; }
        }

       
        public string student_Name
        {
            set { this.Student_Name = value; }
            get { return this.Student_Name; }
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
        public string special_Incident
        {
            set { this.Special_Incident = value; }
            get { return this.Special_Incident; }
        }
        public string marked_By
        {
            set { this.Marked_By = value; }
            get { return this.Marked_By; }
        }
         public string marked_Date
        {
            set { this.Marked_Date = value;}
            get { return this.Marked_Date; }
        }

         public string behavier_Type
        {
            set { this.Behavier_Type = value; }
            get { return this.Behavier_Type; }
        }
         public string load_Photo
        {
            set { this.Load_Photo = value; }
            get { return this.Load_Photo; }
        }
       


   /*     public Behaviers () { }//Default constructor

        public Behaviers(string beid)
        {
            this.student_Id = beid; //custom constructor
        }

        public Behaviers (string sid, string stname, string courid,  string batchid,  string speclinci,  string markedby,  string markddate,  string behvtyp,  string loadphoto )
        {
            this.Student_Id = sid;
            this.Student_Name = stname;
            this.Course_Id = courid;
            this.Batch_Id = batchid;
            this.Special_Incident = speclinci;
            this.Marked_By = markedby;
            this.Marked_Date = markddate;
            this.Behavier_Type = behvtyp;
            this.Load_Photo = loadphoto;
            
        }


        public List<Behaviers> getAllStudentsBehaviers()
        {
            string query = "select * from Behaviers";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            List<Behaviers> BehaviersList = new List<Behaviers>();
            while (reader.Read())
            {
                BehaviersList.Add(new Behaviers(reader["this.Student_Id"].ToString(), reader["this.Student_Name"].ToString(), reader["this.Course_Id"].ToString(), reader["this.Batch_Id"].ToString(), reader["this.Special_Incident"].ToString(), reader["this.Marked_By"].ToString(), reader["this.Marked_Date"].ToString(), reader["this.Behavier_Type"].ToString(), reader["this.Load_Photo"].ToString()));
            }
            return BehaviersList;
        
        }

        public bool insertBehaviers()
        {
            string query = "exec insertBehaviers '" + this.Student_Id + "','" + this.Student_Name + "'," + this.Course_Id + ",'" + this.Batch_Id + "'," + this.Batch_Id + "'," + this.Special_Incident + "','" + this.Marked_By + "','" + this.Marked_Date + "','" + this.Behavier_Type + "','" + this.Load_Photo + "'";
           
            return new DataAccessConnection().executeNonQuery(query);
        }

        public bool updateBehaviers()
        {
            string query = "exec updateStudent '" + this.Student_Id + "','" + this.Student_Name + "'," + this.Course_Id + ",'" + this.Batch_Id + "'," + this.Batch_Id + "'," + this.Special_Incident + "','" + this.Marked_By + "','" + this.Marked_Date + "','" + this.Behavier_Type + "','" + this.Load_Photo + "'";
            return new DataAccessConnection().executeNonQuery(query);
        }

        public bool deleteBehaviers()
        {
            string query = "exec deleteStudent '" + this.Student_Id + "','" + this.Student_Name + "'," + this.Course_Id + ",'" + this.Batch_Id + "'," + this.Batch_Id + "'," + this.Special_Incident + "','" + this.Marked_By + "','" + this.Marked_Date + "','" + this.Behavier_Type + "','" + this.Load_Photo + "'";
            return new DataAccessConnection().executeNonQuery(query);
        }
        
        public Behaviers findBehaviers(string sid)
        {
            string query = "exec getCompleteStudentBehaviersById '" + this.Student_Id + "'";
            SqlDataReader reader = new DataAccessConnection().executeQuery(query);
            Behaviers behavobj = null;
            if (reader.Read())
            {
                behavobj = new Behaviers(reader["this.Student_Id"].ToString(), reader["this.Student_Name"].ToString(), reader["this.Course_Id"].ToString(), reader["this.Batch_Id"].ToString(), reader["this.Special_Incident"].ToString(), reader["this.Marked_By"].ToString(), reader["this.Marked_Date"].ToString(), reader["this.Behavier_Type"].ToString(), reader["this.Load_Photo"].ToString());
            }

            return behavobj;
        }*/

      





    }
}

