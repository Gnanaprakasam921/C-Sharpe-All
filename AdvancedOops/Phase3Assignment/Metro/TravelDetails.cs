using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro
{
    public class TravelDetails
    {
        private static int s_travelledID=2000;
        public string TravelledID { get; }
        public string CardNumber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; set; }
        public double TravelCost { get; set; }

        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, double travelCost)
        {
            s_travelledID++;
            TravelledID="TID"+s_travelledID;
            CardNumber=cardNumber;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            Date=date;
            TravelCost=travelCost;
        }

           public TravelDetails(string travel)
        {
            string[] val=travel.Split(",");
            TravelledID=val[0];
            s_travelledID=int.Parse(val[0].Remove(0,3));
            
            FromLocation=val[1];
            ToLocation=val[2];
            Date=DateTime.ParseExact(val[3],"dd/MM/yyyy",null);
            TravelCost=double.Parse(val[4]);
        }

    }
}