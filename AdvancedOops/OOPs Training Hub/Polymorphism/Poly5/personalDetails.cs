using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Poly5
{
    public abstract class PersonalDetails
    {
        public abstract string Name { get; set; }
        public abstract string FatherName { get; set; }
        public  abstract long Mobile { get; set; }
        public abstract string Gender { get; set; }

        // public personalDetails(string name, string fatherName, long mobile, string gender)
        // {
        //     Name=name;
        //     FatherName=fatherName;
        //     Mobile=mobile;
        //     Gender=gender;
        // }

        public abstract string Dispaly();
      
    }
}