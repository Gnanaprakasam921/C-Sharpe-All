using System;
namespace Single 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            ClassDetails classDetails=new ClassDetails("gnanam","Sekar",987654,"Gnanam@gmail.com",new DateTime(2001,07,28),"male","MCA", "Application",4);
            ClassDetails classDetails1=new ClassDetails("gnanam","Sekar",987654,"Gnanam@gmail.com",new DateTime(2001,07,20),"male","MCA", "Application",4);
            
            classDetails.ShowDetailInfo();

            System.Console.WriteLine(classDetails.ShowDetailInfo());
             System.Console.WriteLine(classDetails1.ShowDetailInfo());
            //classDetails1.ShowDetailInfo();

            
        }
    }
}
