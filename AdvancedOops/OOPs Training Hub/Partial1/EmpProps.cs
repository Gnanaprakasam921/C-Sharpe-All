using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Partial1
{
    public partial class EmpInfo
    {
        private static int s_empID=1000;
        public string EmpID { get;  }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }

        
        
    }
 
}