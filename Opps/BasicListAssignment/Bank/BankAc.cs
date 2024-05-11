using System;

namespace BankingApplication
{

    public enum Gender { Select, Male, Female }
    public class BankAccount
    {
        private static int s_customerID = 1000;
        public string CustomerID { get; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }

        public BankAccount(string customerName, Gender gender, long phone, string email, DateTime dob, double balance)
        {
            s_customerID++;
            CustomerID = "HDFC" + s_customerID;
            CustomerName = customerName;
            Balance = balance;
            Gender = gender;
            Phone = phone;
            Email = email;
            DOB = dob;
        }
        public void Deposite(double amount)
        {
            if(amount>0)
            {
                Balance+=amount;
            }
        }

        public bool Withdrawn(double amount)
        {
          
            if (Balance <= amount)
            {
               Balance-=amount;
               return true;
            }
            else
            {
                return false;
            }

        }

    }


}
