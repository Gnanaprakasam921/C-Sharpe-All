using System;

namespace MultilevelPractice
{
    public class PersonalDeatails 
    {
          public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }

        public PersonalDeatails(string name, string fatherName, DateTime dob)
        {
            Name=name;
            FatherName=fatherName;
            DOB=dob;
        }
    }
}
