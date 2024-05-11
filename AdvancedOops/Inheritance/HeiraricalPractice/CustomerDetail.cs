using System;
using eiraricalPractice;

namespace HeiraricalPractice
{
    public class CustomerDetail:PersonalDeatails
    {
        private static int s_customerID=1000;
        public string CustomerID { get;  }
        public double  Balance { get; set; }

        public CustomerDetail(string name, string fatherName, DateTime dob,double balance):base(name,fatherName,dob)
        {
            s_customerID++;
            CustomerID="SF"+s_customerID;
            Balance=balance;
        }
    }
}
