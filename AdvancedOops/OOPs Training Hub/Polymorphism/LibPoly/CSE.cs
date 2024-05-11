using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibPoly;

namespace LibPoly
{
    public class CSE : Library
    {
        private static  int _sNumber = 1000;
        
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override int Year { get; set; }

        public CSE(string authorName, string bookName, string publisherName, int year)
        {
            _sNumber++;
            SNumber = "CSE" + _sNumber;
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;


        }
        public override string Display()
        {
            return ($"{SNumber}  {AuthorName}  {BookName}  {PublisherName}  {Year}");
        }
    }
}