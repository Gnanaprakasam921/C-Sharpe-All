using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro
{
    public class TicketFairDetails
    {
        private static int s_TicketID=3000;
        public string TicketID { get;  }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public double TicketPrice { get; set; }

        public TicketFairDetails(string fromLocation, string toLocation, double ticketPrice)
        {
            s_TicketID++;
            TicketID="MR"+s_TicketID;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            TicketPrice=ticketPrice;
        }
          public TicketFairDetails(string ticket)
        {
            string[] val=ticket.Split(",");
            TicketID=val[0];
            s_TicketID=int.Parse(val[0].Remove(0,2));
            
            FromLocation=val[1];
            ToLocation=val[2];
            TicketPrice=double.Parse(val[3]);
        }
    }
}