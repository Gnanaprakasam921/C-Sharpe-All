using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
          public StudentInfo(string name, string gender, DateTime dob, long mobile,int phy, int che, int maths)
        {
            s_studID++;
            StudID="SF"+StudID;
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
            Phy=phy;
            Che=che;
            Maths=maths;
        }   
    }
}