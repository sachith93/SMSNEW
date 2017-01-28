using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using StudentManagementSystem.Business;
using StudentManagementSystem.Database;
using System.Windows.Forms;





namespace StudentManagementSystem.Business
{
    public class StudentManagement : ConnectionAccessClass
    {
        private ConnectionAccessClass ConAcsClz;
        public static bool isDuplicate;
        public static bool isForignKey;


        public DataTable SelectAllStudent()
        {
            DataTable dt = FillDataSet("select Student_Id,Student_FullName from Student ").Tables[0]; ;
            DataRow r = dt.NewRow();
            r["Student_Id"] = "0";
            r["Student_FullName"] = " -Select Student- ";
            dt.Rows.InsertAt(r, 0);
            return dt;
        }

        public DataTable SelectLoadAllStudent()
        {
            DataTable dt = FillDataSet("select ID,SupplierName from Tbl_Supplier").Tables[0]; ;
            DataRow r = dt.NewRow();
            r["Student_Id"] = "0";
            r["Student_FullName"] = " -Select Student- ";
            dt.Rows.InsertAt(r, 0);
            return dt;
        }
        
        
        
        
        
        
        
      


        public StudentInfo Select_studentInfo_by_studentId(string student_Id)
        {

            StudentInfo s = new StudentInfo();
            DataTable dt = FillDataSet("Select_studentInfo_by_studentId * from Student where Student_Id ='" + student_Id + "'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    s = convertToObject(r, s);
                }
            }
            return s;
        }
            
       private StudentInfo convertToObject(DataRow r, StudentInfo s)
       {
                    s.Student_Id =int.Parse(r["Student_Id"].ToString());
                    s.Student_FullName = r["Student_FullName"].ToString();
                    s.DOB = r["DOB"].ToString();
                    s.Student_Address = r["Student_Address"].ToString();
                    s.Mobile_Number = r["Mobile_Number"].ToString();
                    s.Land_Number = r["Land_Number"].ToString();
                    s.Gender = r["Gender"].ToString();
                    s.Email = r["Email"].ToString();
                    s.NIC = r["NIC"].ToString();
                    s.Guardian_Name = r["Guardian_Name"].ToString();
                    s.Course_Id = r["Course_Id"].ToString();
                    s.Course_Name = r["Course_Name"].ToString();
                    s.Batch_Id = r["Batch_Id"].ToString();
                    s.Registration_Date = r["Registration_Date"].ToString();

           return s;
       }

       public int Insert_studentDetails(StudentInfo studInfo)
       {
           int flag = 0;
           bool state = false;
           try
           {
               string query = "insert into Student (Student_FullName,DOB,Student_Address,Mobile_Number,Land_Number,Gender,Email,Photo,NIC,Guardian_Name,Course_Id,Course_Name,Batch_Id,Registration_Date,)values('" + studInfo.Student_FullName + "'," + studInfo.DOB + ",'" + studInfo.Student_Address + "'," + studInfo.Mobile_Number + "'," + studInfo.Land_Number + "','" + studInfo.Gender + "','" + studInfo.Email + "','" + studInfo.Photo + "','" + studInfo.NIC + "','" + studInfo.Guardian_Name + "','" + studInfo.Course_Id + "','" + studInfo.Course_Name + "','" + studInfo.Batch_Id + "','" + studInfo.Registration_Date + "')";
               state = new_insert_update_command(query);

               if (state)
                   flag = 1;
               else
               {
                   if (isDuplicate)
                       flag = 2;
                   else
                       flag = 0;
               }
           }
           catch (Exception)
           {
               flag = 0;
           }
           return flag;

       }


       public int UpdateStudentDetailsUsingStudent_Id(StudentInfo editedSInfo)
       {
           int flag = 0;
           bool state = false;
           try
           {
               string query = "update StudentDetails set Student_FullName='" + editedSInfo.Student_FullName + "'," + editedSInfo.DOB + ",'" + editedSInfo.Student_Address + "'," + editedSInfo.Mobile_Number + "'," + editedSInfo.Land_Number + "','" + editedSInfo.Gender + "','" + editedSInfo.Email + "','" + editedSInfo.Photo + "','" + editedSInfo.NIC + "','" + editedSInfo.Guardian_Name + "','" + editedSInfo.Course_Id + "','" + editedSInfo.Course_Name + "','" + editedSInfo.Batch_Id + "','" + editedSInfo.Registration_Date + "';";
               state = new_insert_update_command(query);

               if (state)
                   flag = 1;
               else
               {
                   if (isDuplicate)
                       flag = 2;
                   else
                       flag = 0;
               }
           }
           catch (Exception)
           {
               flag = 0;
           }
           return flag;
       }
        
        
        
        
        public DataTable SelectAllStudents()
        {
            DataTable dt = FillDataSet("select * from Student as s, Student_FullName as r where s.Student_Id=r.Student_Id;").Tables[0];
            return dt;
        }

        public StudentInfo SelectStudentDetailsByUsingStudent_Id (int Student_Id)
        {
            StudentInfo s  = new StudentInfo();
            try
            {
                DataTable dt = FillDataSet("select * from Student where Student_Id='" + Student_Id + "'").Tables[0];
                foreach (DataRow r in dt.Rows)
                {
                    s.Student_FullName = r["Student_FullName"].ToString();
                    s.DOB = r["DOB"].ToString();
                    s.Student_Address = r["Student_Address"].ToString();
                    s.Mobile_Number = r["Mobile_Number"].ToString();
                    s.Land_Number = r["Land_Number"].ToString();
                    s.Gender = r["Gender"].ToString();
                    s.Email = r["Email"].ToString();
                    s.NIC = r["NIC"].ToString();
                    s.Guardian_Name = r["Guardian_Name"].ToString();
                    s.Course_Id = r["Course_Id"].ToString();
                    s.Course_Name = r["Course_Name"].ToString();
                    s.Batch_Id = r["Batch_Id"].ToString();
                    s.Registration_Date = r["Registration_Date"].ToString();
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }

            return s;
        }

       
        public int DeleteStudentDetailsUsingStudent_Id(int Student_Id)
        {
            int flag = 0;
            bool state = false;
            try
            {
                string query = "delete Student where Student_Id='" + Student_Id + "'";
                state = new_insert_update_command(query);

                if (state)
                    flag = 1;
                else
                {
                    if (isDuplicate)
                        flag = 2;
                    else
                        flag = 0;
                }
            }
            catch (Exception)
            {
                flag = 0;
            }
            return flag;
        }









    }
}


