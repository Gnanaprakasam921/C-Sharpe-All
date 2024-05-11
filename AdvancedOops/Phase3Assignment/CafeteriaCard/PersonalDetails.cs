using System;

namespace CafeteriaCard
{
    public enum Gender{Select, Male,Female}
    public class PersonalDetails
    {
        public string Name{ get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public string Mail { get; set; }

       
       public PersonalDetails(string name, string fatherName, Gender gender, long mobile, string mail)
       {
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        Mobile=mobile;
        Mail=mail;
       }
       public PersonalDetails()
       {
        
       }

        interface IBalanceInterface

        {
            //public double WalletBalance { get;  }
            void WalletRecharge(double amount);
            void  DeductAmount(double amount);
        }

       
    }
}
