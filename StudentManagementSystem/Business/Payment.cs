using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Business
{
    class Payment
    {
        private string Receipt_Id;
        private string Course_Id;
        private string Batch_Id;
        private string Student_Id;
        private string Student_Name;
        private string NIC;
        private string Payment_Date;
        private string Total_CourseFee;
        private string Paid_Amount;
        private string Balance;


        public string receipt_Id
        {
            set { this.Receipt_Id = value; }
            get { return this.Receipt_Id; }
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


        public string student_Id
        {
            set { this.Student_Id = value; }
            get { return this.Student_Id; }
        }


        public string student_Name
        {
            set { this.Student_Name = value; }
            get { return this.Student_Name; }
        }


        public string nIC
        {
            set { this.NIC = value; }
            get { return this.NIC; }
        }

         public string payment_Date
        {
            set { this.Payment_Date = value; }
            get { return this.Payment_Date; }
        }


        public string total_CourseFee
        {
            set { this.Total_CourseFee = value; }
            get { return this.Total_CourseFee; }
        }


        public string paid_Amount
        {
            set { this.Paid_Amount = value; }
            get { return this.Paid_Amount; }
        }


        public string balance
        {
            set { this.Balance = value; }
            get { return this.Balance; }
        }




        public Payment() { }//Default constructor

        public Payment(string receiptid)
        {
            this.Receipt_Id = receiptid; //custom constructor
        }

        public Payment (string recptid,  string coursid,  string batchid,  string stuid,  string studname,  string nic, string paymntdate, string totlcourfee, string paidamnt, string balnc)
        {
            this.Receipt_Id = recptid;
            this.Course_Id = coursid;
            this.Batch_Id = batchid;
            this.Student_Id = stuid;
            this.Student_Name = studname;
            this.NIC = nic;
            this.Payment_Date = paymntdate;
            this.Total_CourseFee = totlcourfee;
            this.Paid_Amount = paidamnt;
            this.Balance = balnc;
           
        }


        public List<Payment> getAllStudentsPayments()
        {
            string query = "select * from Payment";
            SqlDataReader reader = new DatabaseConnection().executeQuery(query);
            List<Payment> PaymenttList = new List<Payment>();
            while (reader.Read())
            {
                PaymenttList.Add(new Payment(reader["Receipt_Id"].ToString(), reader["Course_Id"].ToString(), reader["Batch_Id"].ToString(), reader["Student_Id"].ToString(), reader["Student_Name"].ToString(), reader["NIC"].ToString(), reader["Payment_Date"].ToString(), reader["Total_CourseFee"].ToString(), reader["Paid_Amount"].ToString(), reader["Balance"].ToString()));
            }
            return PaymenttList;

        }


        public bool insertPayment()
        {
            string query = "exec insertPayment '" + this.Receipt_Id + "','" + this.Course_Id + "'," + this.Batch_Id + ",'" + this.Student_Id + "','" + this.Student_Name + "','" + this.NIC + "','" + this.Payment_Date + "','" + this.Total_CourseFee + "','" + this.Paid_Amount + "','" + this.Balance + "'";

            return new DatabaseConnection().executeNonQuery(query);
        }



        public bool deletePayment()
         {
             string query = "exec deleteStudent '" + this.Receipt_Id + "','" + this.Course_Id + "'," + this.Batch_Id + ",'" + this.Student_Id + "','" + this.Student_Name + "','" + this.NIC + "','" + this.Payment_Date + "','" + this.Total_CourseFee + "','" + this.Paid_Amount + "','" + this.Balance + "'";
             return new DatabaseConnection().executeNonQuery(query);
         }

        public Payment findPayment(string receipt_Id)
        {
            string query = "exec getCompleteAssignmentfilesById '" + this.Receipt_Id + "'";
            SqlDataReader reader = new DatabaseConnection().executeQuery(query);
            Payment payObj = null;
            if (reader.Read())
            {
                payObj = new Payment(reader["Receipt_Id"].ToString(), reader["Course_Id"].ToString(), reader["Batch_Id"].ToString(), reader["Student_Id"].ToString(), reader["Student_Name"].ToString(), reader["NIC"].ToString(), reader["Payment_Date"].ToString(), reader["Total_CourseFee"].ToString(), reader["Paid_Amount"].ToString(), reader["Balance"].ToString());
            }

            return payObj;

        
        }

    }
}

