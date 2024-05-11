using System;

namespace LibraryManagement
{
    public enum Status{Select,Borrowed,Returned}
    public class BorrowDetails
    {
//         Properties:
// •	BorrowID (Auto Increment – LB2000)
// •	BookID 
// •	UserID
// •	BorrowedDate – ( Current Date and Time )
// •	BorrowBookCount 
// •	Status –  ( Enum - Default, Borrowed, Returned )
// •	PaidFineAmount

        private static int s_borrowID=2000;
        public string BorrowID { get; set; }
        public string BookID { get; set; }
        public string UserID { get; set; }
        public DateTime CurrentDate { get; set; }
        public int BorrowBookCount { get; set; }
        public Status Status { get; set; }
        public double PaidFineAmount { get; set; }
        
        public BorrowDetails(string bookID, string userID, DateTime currentDate, int borrowBookCount, Status status,double paidFineAmount)
        {
            s_borrowID++;
            BorrowID="LB"+s_borrowID;
            BookID=bookID;
            UserID=userID;
            CurrentDate=currentDate;
            BorrowBookCount=borrowBookCount;
            Status=status;
            PaidFineAmount=paidFineAmount;
        }

    }
}
