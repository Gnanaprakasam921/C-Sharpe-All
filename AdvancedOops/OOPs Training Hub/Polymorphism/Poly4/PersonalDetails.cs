using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly4
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }

        public PersonalDetails(string name, string fatherName, string gender, string qualification)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Qualification=qualification;
        }
    }
}