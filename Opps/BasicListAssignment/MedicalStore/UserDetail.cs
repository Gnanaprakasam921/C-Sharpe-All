using System;

namespace MedicalStore
{
    
    public class UserDetail
    {
//         Properties:
// a.	UserID (Auto increment – UID1000)
// b.	UserName
// c.	Age
// d.	City
// e.	PhoneNumber
// f.	Balance

            private static int s_userID=1000;
            public string  UserID { get;  }
            public string UserName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
            public long Mobile { get; set; }
            public double Balance { get; set; }

            public UserDetail(string userName, int age, string city, long mobile, double balance)
            {
                s_userID++;
                UserID="UID"+s_userID;
                UserName=userName;
                Age=age;
                City=city;
                Mobile=mobile;
                Balance=balance;
            }

              public void WalletRecharege(double amount)
        {
            if(amount>0)
            {
                Balance+=amount;
            }
        }
            

    }
}
