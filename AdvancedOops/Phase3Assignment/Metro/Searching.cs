using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro
{
    public class Searching
    {
        public static UserDetails LoginSearch(string cardNumber)
        {
        CustomList<UserDetails> userList=Operation.userList;
        int start=0;
        int end=userList.Count-1;
        while(start<end)
        {
            int middle=(start+end)/2;
            if(userList[middle].CardNumber==cardNumber)
            {
                return userList[middle];
            }
            else if(string.Compare(userList[middle].CardNumber,cardNumber)<0)
            {
                start=middle+1;

            }
            else
            {
                end=middle-1;
            }
        }
        return null;
        }


//         public static TicketFairDetails TicketCheck(string ticketID)
//         {
//             CustomList<TicketFairDetails> ticketList=Operation.ticketList;
//             int start=0;
//             int end=ticketList.Count-1;
//             while(start<end)
//             {
//                 int mid=(start+end)/2;
//                 if(ticketList[mid].TicketID==ticketID)
//                 {
//                     return ticketList[mid];
//                 }
//                 else if(string.Compare(ticketList[mid].TicketID,ticketID)<0)
//                 {
//                     start=mid+1;
//                 }
//                 else
//                 {
//                     end=mid-1;
//                 }
               
//             }
//              return null;
//         }
       
    }
}