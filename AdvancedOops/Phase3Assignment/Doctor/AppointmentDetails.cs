using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor
{
    public class AppointmentDetails
    {
        private static int s_appointmentID=3000;
        public string AppointmentID { get;  }
        public string PatientID { get; set; }
        public string  DoctorID { get; set; }
        public DateTime Date { get; set; }
        public string Problem { get; set; }

        public AppointmentDetails(string patientID,string doctorID,DateTime date,string problem)
        {
            s_appointmentID++;
            AppointmentID="AID"+s_appointmentID;
            PatientID=patientID;
            DoctorID=doctorID;
            Date=date;
            Problem=problem;
        }
    }
}