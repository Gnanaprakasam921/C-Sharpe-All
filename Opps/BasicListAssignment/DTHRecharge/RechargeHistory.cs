using System;

namespace DTHRecharge
{
    public class RechargeHistory
    {
        private static int s_rechargeID=100;
        public string RechargeID { get;  }
        public string UserID { get; set; }
        public string  PackID { get; set; }
        public DateTime RechargeDate { get; set; }
        public double RechargeAmount { get; set; }
        public DateTime ValidTill { get; set; }
        public int NumberOfChennal { get; set; }
        public RechargeHistory(string userID, string packID, DateTime rechargeDate, double rechargeAmount,DateTime validTill, int numberOfChennal)
        {
            s_rechargeID++;
            RechargeID="RI"+s_rechargeID;
            UserID=userID;
            PackID=packID;
            RechargeDate=rechargeDate;
            RechargeAmount=rechargeAmount;
            ValidTill=validTill;
            NumberOfChennal=numberOfChennal;
        }
    }
}
