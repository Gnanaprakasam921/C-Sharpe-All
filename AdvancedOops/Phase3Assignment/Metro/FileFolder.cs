using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Metro
{
    public class FileFolder
    {
        public static void Create()
        {
            if(!Directory.Exists("Metro"))
            {
                System.Console.WriteLine("FoderCreated..");
                Directory.CreateDirectory("Metro");
            }
            if(!File.Exists("Metro/UserDetails.csv"))
            {
                System.Console.WriteLine("userDetails csv created");
                File.Create("Metro/UserDetails.csv");

            }
             if(!File.Exists("Metro/TravelDetails.csv"))
            {
                System.Console.WriteLine("travelDetails csv created");
                File.Create("Metro/TravelDetails.csv");
                
            }
             if(!File.Exists("Metro/TicketFairDetails.csv"))
            {
                System.Console.WriteLine("Ticketfair Details csv created");
                File.Create("Metro/TicketFairDetails.csv");
                
            }
        }
        public static void WriteCsv()
        {
            string[] user=new string[Operation.userList.Count];
            for(int i=0;i<Operation.userList.Count;i++)
            {
                user[i]=Operation.userList[i].CardNumber+","+Operation.userList[i].Name+","+Operation.userList[i].Phone+","+Operation.userList[i].Balance;
            }
            File.WriteAllLines("Metro/UserDetails.csv",user);

            string[] ticket=new string[Operation.ticketList.Count];
            for(int i=0;i<Operation.ticketList.Count;i++)
            {
                ticket[i]=Operation.ticketList[i].TicketID+","+Operation.ticketList[i].FromLocation+","+Operation.ticketList[i].ToLocation+","+Operation.ticketList[i].TicketPrice;
            }
            File.WriteAllLines("Metro/TicketFairDetails.csv",ticket);

            string[] traval=new string[Operation.travelList.Count];
            for(int i=0;i<Operation.travelList.Count;i++)
            {
                traval[i]=Operation.travelList[i].TravelledID+","+Operation.travelList[i].FromLocation+","+Operation.travelList[i].ToLocation+","+Operation.travelList[i].Date.ToString("dd/MM/yyyy")+","+Operation.travelList[i].TravelCost;
            }
            File.WriteAllLines("Metro/TravelDetails.csv",traval);
        }

        public static void ReadCsv()
        {
            string[] users=File.ReadAllLines("Metro/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails user1=new UserDetails(user);
                Operation.userList.Add(user1);
            }

              string[] tickets=File.ReadAllLines("Metro/TicketFairDetails.csv");
            foreach(string ticket in tickets)
            {
                TicketFairDetails ticket1=new TicketFairDetails(ticket);
                Operation.ticketList.Add(ticket1);
            }

             string[] travels=File.ReadAllLines("Metro/TravelDetails.csv");
            foreach(string traval in travels)
            {
                TravelDetails travel1=new TravelDetails(traval);
                Operation.travelList.Add(travel1);
            }
           
        }



        
    }
}