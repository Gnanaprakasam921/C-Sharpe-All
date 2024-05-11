using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract2
{
    public abstract class Library
    {
        private int _sNumber=1000;
        public string SNumber { get;set; }
        public abstract string  AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public  abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }

 
        
        public abstract string  Display();
//{
            //return($"{SNumber}  {AuthorName}  {BookName}  {PublisherName}  {Year}");
        //}
    }
}