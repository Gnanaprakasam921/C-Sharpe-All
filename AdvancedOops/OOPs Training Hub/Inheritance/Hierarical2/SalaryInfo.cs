using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarical2
{
    public class SalaryInfo
    {
        public double BasicSalary { get; set; }
        public int Month { get; set; }

        public SalaryInfo(double basicsalary, int month)
        {
            BasicSalary=basicsalary;
            Month=month;
        }
    }
}