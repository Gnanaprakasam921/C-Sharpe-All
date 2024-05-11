using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public class Syncfusion : Salary
    {
        public override string CompanyName{get;set;}

        public Syncfusion(string empID,string name, string companyName)
        {
            EmpID=empID;
            Name=name;
            CompanyName=companyName;
        }

        public override void CalcSalary(int days, double amount)
        {
            double salary=days*amount;
            TotalSalary=0.10*salary+salary;
        }
    }
}