using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarical2
{
    public class TemproryEmp : SalaryInfo
    {
           private static int s_empID=1000;
        public string EmpID { get;  }
        public string EmpType { get; set; }
        public double DA { get{return 0.15*BasicSalary;}  }
        public double HRA{ get {return 0.13*BasicSalary;}}
        //public double PF{get {return 0*BasicSalary;}}
        public double TotalSalary { get; set; }

        public TemproryEmp(double basicsalary, int month, string emptype) : base(basicsalary, month)
        {
            s_empID++;
            EmpID="SF"+s_empID;
            EmpType=emptype;
            //DA=da;

        }

        public double Total()
        {
            TotalSalary= BasicSalary+DA+HRA;
            return TotalSalary;
        }

        public double ShowSalary()
        {
            return TotalSalary;
        }
       
    }
}