using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel2
{
    public class BookInfo : RankInfo
    {
        private static int s_bookId=100;
        public string BookId { get;  }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public BookInfo(string deptnName, string degree, int rackno, int colno,string bookName, string authorName, double price) : base(deptnName, degree, rackno, colno)
        {

            s_bookId++;
            BookId="SF"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }

        public string DisplayInfo()
        {
            return($"{BookId}  {BookName}  {AuthorName}  {Price}  {RackNo}  {ColNo}  {DeptName}  {Degree}");
        }
    }
}