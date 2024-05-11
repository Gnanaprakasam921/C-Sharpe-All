using System;

namespace VaccinationDrive
{
   public enum VaccineName{Select, Covaccine, Covishield}
    public class VaccineDetails
    {
        
         private static int s_vaccineID=2000;
         public string VaccineID { get; }
         public VaccineName VaccineName { get; set; }
         public int NoOfDose { get; set; }

         public VaccineDetails(VaccineName vaccineName, int noOfDose)
         {
            s_vaccineID++;
            VaccineID="CID"+s_vaccineID;
            VaccineName=vaccineName;
            NoOfDose=noOfDose;

         }
    }
}
