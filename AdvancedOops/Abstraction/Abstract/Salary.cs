using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    // Partial Abstraction
    public abstract class Salary
    {
        // Never static 
        // Field May be
        // normal and abstract prop available
        // No constructor
        // Normal and abstract method available
        // Cannot create objct for this
        // Can be used only with inheritance
        // method are abstract or non abstract

        public String  EmpID { get; set; }
        public string Name { get; set; }
        public abstract string  CompanyName { get; set; }
        public double  TotalSalary { get; set; }
        public abstract void CalcSalary(int days, double amount);
       
    }
}