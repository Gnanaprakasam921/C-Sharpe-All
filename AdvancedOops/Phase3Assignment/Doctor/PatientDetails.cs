using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor
{
    public enum Gender{select, Male, Female}
    public class PatientDetails
    {
        private static int s_patientID=2000;
        public string PatientID { get;  }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public PatientDetails(string password, string name, int age, Gender gender)
        {
            s_patientID++;
            PatientID="PID"+s_patientID;
            Password=password;
            Name=name;
            Age=age;
            Gender=gender;
        }


    }
}