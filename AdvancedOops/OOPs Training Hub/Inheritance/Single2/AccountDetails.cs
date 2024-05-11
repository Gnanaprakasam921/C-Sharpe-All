using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Single;

namespace Single2
{
    public class AccountDetails:PersionalDetail
    {
        public static int s_accNO=1000;

       

        public long AccNO { get; set;}
        public string Branch { get; set; }
        public long IFSC { get; set; }
        public double Balance { get; set; }
         public AccountDetails(string name, string fatherName, long mobile, string mail, DateTime dob, string gender,long accNo, string branch, long iffc, double balance) : base(name, fatherName, mobile, mail, dob, gender)
        {
            AccNO=accNo;
            Branch=branch;
            IFSC=iffc;
            Balance=balance;

        }

        public  string ShowInfo()
        {
            return ($"{Name}  {FatherName}  {Mobile}  {Mail}  {DOB}  {Gender}  {AccNO}  {Branch}  {IFSC}  {Balance}");
        }

        public double Deposite(double amount)
        {
            if(amount>0)
            {
                Balance=Balance+amount;
            }
            return Balance;
        }
        public double Withrown(double amount)
        {
            if(amount<=Balance)
            {
                Balance=Balance-amount;
                
            }
            return Balance;
        }

        public double ShowBalance()
        {
                return Balance;
        }
        
    }
}