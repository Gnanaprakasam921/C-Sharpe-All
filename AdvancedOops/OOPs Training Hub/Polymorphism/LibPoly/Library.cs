using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibPoly
{
    public abstract class Library
    {
        private static int s_sNumber;
        public string SNumber { get;set; }
        public abstract string  AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public  abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }

        // public Library()
        // {
        //     _sNumber++;
        //     SNumber="SF"+_sNumber;
        // }
        //     AuthorName=authorName;
        //     BookName=bookName;
        //     PublisherName=publisherName;
        //     Year=year;
        // }

        // public Library(string serialNumber,string authorName, string bookName, string publisherName, int year)
        // {
        //     SNumber=serialNumber;
        // }
        
        public abstract string  Display();
//{
            //return($"{SNumber}  {AuthorName}  {BookName}  {PublisherName}  {Year}");
        //}
    }
}