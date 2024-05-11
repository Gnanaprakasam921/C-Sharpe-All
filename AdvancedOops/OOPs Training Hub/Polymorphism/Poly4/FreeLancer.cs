using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly4
{
    public class FreeLancer : PersonalDetails
    {
        public string Role { get; set; }
        public double Salary { get; set; }
        public double Wrodkingdays { get; set; }
        public FreeLancer(string name, string fatherName, string gender, string qualification,string role,  int workingdays) : base(name, fatherName, gender, qualification)
        {
            Role=role;
            //Salary=salary;
            Wrodkingdays=workingdays;

        }

        public virtual double CalcSalary()
        {
          double  Salary= Wrodkingdays*500;
          return Salary;
        }

        // public virtual double Sal()
        // {
        //     return CalcSalary();
        // }
        public virtual string Display()
        {
            return($"{Name}  {FatherName}  {Gender}  {Qualification}  {Role}  {CalcSalary()}  {Wrodkingdays}");
        }
    }
}