using System;

namespace SyncAdmission
{
    public enum AdmissionStatus{Select, Admitted, Cancelled}
    public class AdmissionDetail
    {
        private static int s_admissionID=1000;
        public string AdmissionID { get; }
        public string StudentID { get; set; }
        public string DepartmentID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }

        public AdmissionDetail(string studentID,string departmentID, DateTime admissionDate, AdmissionStatus admissionStatus)
        {
            s_admissionID++;
            AdmissionID="AID"+s_admissionID;

            StudentID=studentID;
            DepartmentID=departmentID;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;

        }

         public AdmissionDetail(string admission)
        {
            string[] value=admission.Split(",");
            AdmissionID=value[0];
            s_admissionID=int.Parse(value[0].Remove(0,3));
            

            StudentID=value[1];
            DepartmentID=value[2];
            AdmissionDate=DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
            AdmissionStatus=Enum.Parse<AdmissionStatus>(value[4]);

        }
    }
}
