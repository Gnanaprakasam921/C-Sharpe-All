using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly5
{
    public class EmpInfo:PersonalDetails
    {
         private int _empID=1000;
         public string EmpID { get;  }
          public override string Name { get; set; }
        public override string FatherName { get; set; }
        public override  long Mobile { get; set; }
        public override string Gender { get; set; }
        public EmpInfo(string name, string fatherName, long mobile, string gender) 
        {
            _empID++;
            EmpID="SF"+_empID;
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Gender=gender;
        }
        public override string Dispaly()
        {
             return($"{EmpID} {Name}  {FatherName}  {Mobile}  {Gender}");
        }
        }

       
    }
