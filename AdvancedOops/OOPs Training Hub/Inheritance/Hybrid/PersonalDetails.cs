using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical
{
    public class PersonalDetails
    {
         public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }

        public PersonalDetails(string name, string fatherName, long mobile, string mail, DateTime dob, string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }

        public  string ShowDetails()
        {
            return ($"{Name}  {FatherName}  {Mobile}  {DOB}  {Gender}");
        }
    }
}