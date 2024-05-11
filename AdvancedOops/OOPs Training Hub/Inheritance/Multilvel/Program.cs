using System;
using Multilvel;
namespace Multilel
{
    class Program 
    {
        public static void Main(string[] args)
        {


            PersionalDetail persionalDetail=new PersionalDetail("gnanam","Sekar",8765,"jsfkd",new DateTime(2001,07,24),"Male");
          //  System.Console.WriteLine(persionalDetail.);
            StudentInfo studentInfo=new StudentInfo("gnanam","Sekar",8765,"jsfkd",new DateTime(2001,07,24),"Male","MCA","aplic",4);
            System.Console.WriteLine(studentInfo.ShowDetail());

            HSCDetails hSCDetails=new HSCDetails("gnanam","Sekar",8765,"jsfkd",new DateTime(2001,07,24),"Male","MCA","aplic",4, 87,98,99);

            
            

            HSCDetails hSCDetails1=new HSCDetails("gnanam","Sekar",8765,"jsfkd",new DateTime(2001,07,24),"Male","MCA","aplic",4, 87,98,99);

            hSCDetails.Calculate();

           System.Console.WriteLine(hSCDetails.ShowMarkSheet()); 

          
        }
    }
}