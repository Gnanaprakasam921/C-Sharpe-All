using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel2
{
    public class DeptDetails
    {
        public string DeptName { get; set; }
        public string Degree { get; set; }

        public DeptDetails(string deptnName, string degree)
        {
            DeptName=deptnName;
            Degree=degree;
        }
    }
}