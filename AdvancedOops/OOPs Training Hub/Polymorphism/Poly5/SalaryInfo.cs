using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly5
{
    public class SalaryInfo : EmpInfo
    {
        private int _wrokingDays;
        public int WorkinDays { get; set; }
        public SalaryInfo(string name, string fatherName, long mobile, string gender,int wrokingDays) : base(name, fatherName, mobile, gender)
        {
            _wrokingDays=wrokingDays;
        }

        public double Salary()
        {
            return _wrokingDays*500;
        }

        public override string Dispaly()
        {
              return($"{EmpID} {Name}  {FatherName}  {Mobile}  {Gender} {Salary()}");
        }
    }
}