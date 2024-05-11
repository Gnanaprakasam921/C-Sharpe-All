using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly4
{
    public class SyncFusion : FreeLancer
    {
        private int _empID=100;
        public string EmpID { get;  }
        public string Location { get; set; }
        public SyncFusion(string name, string fatherName, string gender, string qualification, string role, int workingdays,string location) : base(name, fatherName, gender, qualification, role, workingdays)
        {
            _empID++;
            EmpID="SF"+_empID;
            Location=location;
        }
        public override double CalcSalary()
        {
            return base.CalcSalary();
        }

        public virtual string Display()
        {
            return($"{EmpID}  {Name}  {FatherName}  {Gender}  {Qualification}  {Role}  {CalcSalary()}  {Wrodkingdays}  {Location}");
        }

    }
}