using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial1
{
    public partial class EmpInfo
    {
     public EmpInfo(string name, string gender, DateTime dob, long mobile)
        {
            s_empID++;
            EmpID="SF"+s_empID;
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
        }   
    }
}