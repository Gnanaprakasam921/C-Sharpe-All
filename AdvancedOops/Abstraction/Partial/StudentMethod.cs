using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial
{
    public partial class StudentDetails
    {
        public partial void GetBalance(double amount)
        {
            _balance+=amount;
        }
        
        public double ShowBalance()
        {
            return _balance;
        }
}
}