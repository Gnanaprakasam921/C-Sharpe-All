using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid1
{
    public interface ICalculate
    {
        void Deposite(double amount);
        void Withdrawn(double amount);
        void BalanceCheck();
    }
}