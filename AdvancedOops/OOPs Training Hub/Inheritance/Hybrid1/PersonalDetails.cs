using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple
{
  
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }
        //public Marital  Marital { get; set; }

        public PersonalDetails(string name, string gender, DateTime dob, long mobile)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
            //Marital=marital;
        }

      
    }
}