using System;

namespace ECommerce
{
    public class CustomerDetails
    {
        private static int s_cutomerID=3000; 
        
        public string CustomerID { get; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public long Mobile { get; set; }
   
        public string Email { get; set; }
        
        public CustomerDetails(string customerName,string city, long mobile, int walletBalance, string email )
        {
            s_cutomerID++;
            CustomerID="CID"+s_cutomerID;
            CustomerName=customerName;
            City=city;
            Mobile=mobile;
            WalletBalance=walletBalance;
            Email=email;
        }

         public void WalletRecharege(double amount)
        {
            if(amount>0)
            {
                WalletBalance+=amount;
            }
        }

        public bool DeductBalance(double amount)
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
