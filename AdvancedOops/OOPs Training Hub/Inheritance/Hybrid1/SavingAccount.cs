using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid1
{
    public class SavingAccount:IDInfo,ICalculate,IBankInfor
    {
       

        public long AccNO { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }
         public string BankName { get; set; }
        public long IFSC { get; set; }
        public string Branch { get; set; }
        
         public SavingAccount(string name, string gender, DateTime dob, long mobile, string voiter, string aadhar, string pan,long accNo, string accType,string bankName, string branch,double balance) : base(name, gender, dob, mobile, voiter, aadhar, pan)
        {

            AccNO=accNo;
            AccountType=accType;
            BankName=bankName;
            Branch=branch;
            Balance=balance;


        }
        public void Deposite(double amount)
        {
            if(amount>0)
            {
                Balance +=amount;
            }
            
        }

        public void Withdrawn(double amount)
        {
            if(amount<=Balance)
            {
                Balance -=amount;
            }
        }

        public double BalanceCheck()
        {
            return Balance;
        }

       

        void ICalculate.BalanceCheck()
        {
            throw new NotImplementedException();
        }
    }
}