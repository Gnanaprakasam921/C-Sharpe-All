using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid1
{
    public interface IBankInfor
    {
        public string BankName { get; set; }
        public long IFSC { get; set; }
        public string Branch { get; set; }

        
    }
}