using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterFace2
{
    public class EmployeeInfo
    {
        private static int s_empID;
         public string EmpID { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
      //  public long Mobile { get; set; }

        public EmployeeInfo(string name,string fatherName)
        {
            s_empID++;
            EmpID="SF"+EmpID;
            Name=name;
            FatherName=fatherName;
           // Mobile=mobile;

        }
        public string Display()
        {
            return($"{EmpID}  {Name}  {FatherName}  ");
        }
    }
}