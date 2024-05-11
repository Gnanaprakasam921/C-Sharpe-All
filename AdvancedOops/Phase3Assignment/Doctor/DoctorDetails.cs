using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor
{
    public class DoctorDetails
    {
        private static int s_doctorID=1000;
        public string DoctorID { get; }
        public string Name { get; set; }
        public string Department { get; set; }

        public DoctorDetails(string name, string department)
        {
            s_doctorID++;
            DoctorID="SF"+s_doctorID;
            Name=name;
            Department=department;
        }
    }
}