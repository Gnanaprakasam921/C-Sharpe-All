using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public class TCS:Salary
    {
          public override string CompanyName{get;set;}

        public TCS(string empID,string name, string companyName)
        {
            EmpID=empID;
            Name=name;
            CompanyName=companyName;
        }

        public override void CalcSalary(int days, double amount)
        {
            double salary=days*amount;
            TotalSalary=0.18*salary+salary;
        }
    }
}