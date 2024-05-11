using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarical2
{
    public class PermenentEmp : SalaryInfo
    {
        private static int s_empID=1000;
        public string EmpID { get;  }
        public string EmpType { get; set; }
        public double DA { get{return 0.2*BasicSalary;}  }
        public double HRA{ get {return 0.18*BasicSalary;}}
        public double PF{get {return 0.1*BasicSalary;}}
        public double TotalSalary { get; set; }

        public PermenentEmp(double basicsalary, int month, string emptype) : base(basicsalary, month)
        {
            s_empID++;
            EmpID="SF"+s_empID;
            EmpType=emptype;
            //DA=da;

        }

        public double Total()
        {
            TotalSalary= BasicSalary+DA+HRA-PF;
            return TotalSalary;
        }

        public double ShowSalary()
        {
            return TotalSalary;
        }
    }
}