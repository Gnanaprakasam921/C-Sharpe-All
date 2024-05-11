using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro
{
    public class UserDetails:PersonalDetails,IBalance
    {
        private static int s_cardNumber=1000;

       

        public string CardNumber { get;  }
        public double Balance { get; set; }

         public UserDetails(string name, long phone,double balance) : base(name, phone)
        {
            s_cardNumber++;
            CardNumber="CMR"+s_cardNumber;
            Balance=balance;
        }

        public UserDetails(string user)
        {
            string[] val=user.Split(",");
           CardNumber=val[0];
            s_cardNumber=int.Parse(val[0].Remove(0,3));
            
            Name=val[1];
            Phone=long.Parse(val[2]);
            Balance=double.Parse(val[3]);
            
        }

        public void WalletRecharge(double amount)
        {
            if(amount>0)
            {
                Balance=Balance+amount;
            }
        }
        public bool DeductBalance(double amount)
        {
            if(Balance<amount)
            {
                Balance=Balance-amount;
                return true;
            }
            return false;
        }


    }
}