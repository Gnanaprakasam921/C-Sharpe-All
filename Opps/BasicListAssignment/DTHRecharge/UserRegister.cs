using System;

namespace DTHRecharge
{
    public class UserRegister
    {
        private static int s_userID=1000;
        public string UserID { get; }
        public string UserName { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }
        public double WalletBalance { get; set; }

        public UserRegister(string userName,long mobile, string email, double walletBalance)
        {
            s_userID++;
            UserID="UID"+s_userID;
            UserName=userName;
            Mobile=mobile;
            Email=email;
            WalletBalance=walletBalance;
            
        }
          public void WalletRecharege(int amount)
        {
            if(amount>0)
            {
                WalletBalance+=amount;
            }
        }
        
    }
}
