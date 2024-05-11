using System;
using System.ComponentModel.Design;

namespace LibraryManagement
{
    public enum Department{Select, ECE,EEE,CSE}
    public enum Gender{Select, Male, Female}
    public class UserDetails
    {
//         Properties:
// a.	UserID (Auto Increment – SF3000)
// b.	UserName
// c.	Gender
// d.	Department – (Enum – ECE, EEE, CSE)
// e.	MobileNumber
// f.	MailID
// g.	WalletBalance

        private static int s_userID=3000;
        public string  UserID { get;  }
        public string  UserName{ get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public long Mobile { get; set; }
        public string MailID { get; set; }
        public double WalletBalance { get; set; }
        
        public UserDetails(string userName, Gender gender, Department department, long mobile, string mailID, double walletBalance)
        {
            s_userID++;
            UserID="SF"+s_userID;
            UserName=userName;
            Gender=gender;
            Department=department;
            Mobile=mobile;
            MailID=mailID;
            WalletBalance=walletBalance;
        }

         public void WalletRecharege(int amount)
        {
            if(amount>0)
            {
                WalletBalance+=amount;
            }
        }

        public bool DeductBalance(int amount)
        {
          
            if (WalletBalance >= amount)
            {
               WalletBalance-=amount;
               return true;
            }
            else
            {
                return false;
            }

        }



    }
}
