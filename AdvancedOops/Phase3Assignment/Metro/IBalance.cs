using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro
{
    public interface IBalance
    {
         double Balance { get; set; }

        void WalletRecharge(double amount);
        bool DeductBalance(double amount); 
    }
}