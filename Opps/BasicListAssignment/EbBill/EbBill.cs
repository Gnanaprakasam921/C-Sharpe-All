using System;

namespace EbBillCalculation
{

   
    public class EbBill
    {
        private static int s_meterID = 1000;
        public string MeterID { get; }
        public string UserName { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public int UnitUsed { get; set; }

        public EbBill(string userName,  long phone, string email, int unitUsed)
        {
            s_meterID++;
            MeterID = "EB" + s_meterID;
            UserName = userName;
            Phone = phone;
            Email = email;
            UnitUsed = unitUsed;
        }



        public void AmountCalc(double amount)
        {
            amount=UnitUsed*5;
        }
        // public void Deposite(double amount)
        // {
        //     if(amount>0)
        //     {
        //         Balance+=amount;
        //     }
        // }

        // public bool Withdrawn(double amount)
        // {
          
        //     if (Balance <= amount)
        //     {
        //        Balance-=amount;
        //        return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }

        //}

    }


}
