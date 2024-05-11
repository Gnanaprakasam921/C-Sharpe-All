using System;

namespace VaccinationDrive
{
    
    public class VaccinationDetails
    {
        private static int s_VaccinationID=3000;
        public string VaccinationID { get; }
        public string  RegisterID { get; set; }
        public string VaccineID { get; set; }
        public int DoseNumber { get; set; }
        public DateTime VaccinationDate { get; set; }
        public VaccinationDetails(string registerID, string vaccineID, int doseNumber, DateTime vaccinationDate)
        {
            s_VaccinationID++;
            VaccinationID="UID"+s_VaccinationID;
            RegisterID=registerID;
            VaccineID=vaccineID;
            DoseNumber=doseNumber;
            VaccinationDate=vaccinationDate;
        }
        
    }
}
