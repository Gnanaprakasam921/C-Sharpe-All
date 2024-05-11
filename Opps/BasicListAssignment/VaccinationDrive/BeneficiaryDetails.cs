using System;

namespace VaccinationDrive
{
    public enum Gender{Select, Male,Female}
    public class BeneficiaryDetails
    {
        private static int s_registerID=1000;
        public string RegisterID { get;  }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public string City { get; set; }
        public BeneficiaryDetails(string name, int age, Gender gender,long mobile, string city)
        {
            s_registerID++;
            RegisterID="BID"+s_registerID;
            Name=name;
            Age=age;
            Gender=gender;
            Mobile=mobile;
            City=city;
        }


    }
}
