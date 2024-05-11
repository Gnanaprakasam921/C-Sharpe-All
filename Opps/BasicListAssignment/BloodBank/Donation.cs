using System;

namespace BloodBank
{
    public enum BloodGroup{Select, A, B, O, AB}
    public class Donation
    {
        private static int s_DonationID=1000;
        public string DonationID { get;  }
        public string DonerID { get; set; }
        public DateTime DonationDate { get; set; }
        public double Weight { get; set; }
        public double BloodPrasure { get; set; }
        public double Hemoclobin { get; set; }
        public BloodGroup BloodGroup{get;set;}

        public Donation( string donerID,DateTime donationDate, double weight, double bloodPrasure, double hemoclobin,BloodGroup bloodGroup)
        {
            s_DonationID++;
            DonationID="DID"+s_DonationID;
            DonerID=donerID;
            DonationDate=donationDate;
            Weight=weight;
            BloodPrasure=bloodPrasure;
            Hemoclobin=hemoclobin;
            BloodGroup=bloodGroup;
        }

    }
    
}
