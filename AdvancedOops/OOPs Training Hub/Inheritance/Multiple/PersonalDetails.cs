using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple
{
    public enum Marital{Married, Single}
    public class PersonalDetails:IShowData
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }
        public Marital  Marital { get; set; }

        public PersonalDetails(string name, string gender, DateTime dob, long mobile, Marital marital)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
            Marital=marital;
        }

        public string ShowDetails()
        {
         return($"{Name}  {Gender}  {DOB}  {Mobile}  {Marital}");
           
        }
    }
}