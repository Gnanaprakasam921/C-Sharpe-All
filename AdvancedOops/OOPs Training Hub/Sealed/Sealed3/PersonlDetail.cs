using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed3
{
    public class PersonlDetail
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        public string Gender { get; set; }
        public PersonlDetail(string name, string fatherName, long mobile, string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Gender=gender;
        }

        public virtual void Update();
    }
}