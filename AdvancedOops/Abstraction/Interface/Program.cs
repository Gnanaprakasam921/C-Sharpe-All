using System;
using System.Collections.Generic;
namespace Interface 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           //ImarkDetails imark=new ImarkDetails();   cant create object for interface

           StudentDetails student=new StudentDetails(50,60,70);

           IMarkDetails mark=new StudentDetails(10,20,30);
           System.Console.WriteLine(mark.Mark1);

           IMarkDetails mark1=new Marksheet(40,89,30);
           List<IMarkDetails> markDetail =new List<IMarkDetails>();
           markDetail.Add(student);
           markDetail.Add(mark);
           markDetail.Add(mark1);

        }
    }
}
