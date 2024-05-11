using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed1
{
    public class PersonalInfo
    {
         public string Name { get; set; }
         public string FatherName { get; set; }
        public string Gender { get; set; }
        public string Mail { get; set; }
        public long Mobile { get; set; }
        
        public PersonalInfo(string name, string fatherName, string gender, string mail, long mobile)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mail=mail;
            Mobile=mobile;
        }
        public void Display()
        {
            
        }
    }
}