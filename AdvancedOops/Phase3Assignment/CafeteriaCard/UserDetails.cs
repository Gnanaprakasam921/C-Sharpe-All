using System;

namespace CafeteriaCard
{
    public class UserDetails : PersonalDetails
    {
        private static int s_userID=1000;
        public string UserID { get;  }
        public string WorkStationNumber { get; set; }

        //field
        private double _balance;

        public double WalletBalance { get{return _balance;} }
        //public double WalletBalance { get;set; }

        public UserDetails(string name,string fatherName, long mobile,string mail, Gender gender,string workStationNumber,double walletBalance):base(name,fatherName,gender,mobile,mail)
        {
            s_userID++;
            UserID="SF"+s_userID;
          
            WorkStationNumber=workStationNumber;
            _balance =walletBalance;

        }

         public UserDetails(string user)
        {
            string[] value= user.Split(",");
           
            
            s_userID=int.Parse(value[0].Remove(0,2));
            UserID=value[0];
            Name=value[1];
            FatherName=value[2];
            Mobile=long.Parse(value[3]);
            Mail=value[4];
            Gender=Enum.Parse<Gender>(value[5]);
            WorkStationNumber=value[6];
            _balance =double.Parse(value[7]);

        }

        public  void WalletRecharge(double amount)
        {
            if(amount>0)
            {
                _balance=WalletBalance+amount;
            }

        }

        public  bool DeductAmount(double amount)
        {
            if(WalletBalance>amount)
            {
                _balance=WalletBalance-amount;
                return true;
            }
            return false;
        }

     

    }
}
