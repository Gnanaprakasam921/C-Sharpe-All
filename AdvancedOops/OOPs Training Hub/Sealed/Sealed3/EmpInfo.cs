using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed3
{
    public class EmpInfo:FamilyInfo
    {
        public string EmpID { get; set; }

        public DateTime Joining{get;set;}
    }
}