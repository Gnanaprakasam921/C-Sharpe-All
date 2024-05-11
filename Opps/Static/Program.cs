using System;
using System.Security.Cryptography.X509Certificates;
namespace Static 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            //  Non static element 

            // PersonDetail person1=new PersonDetail();
            // PersonDetail person2=new PersonDetail();
            // person1.name="Gnanam";
            
            // person1.FatherName="Sekar";
            // PersonDetail.tax=21;   // if we create static element call this way
            // person2.name="gokul";
            // person2.FatherName="ravi";
            // PersonDetail.tax=12;

            // static

            //PersonDetail val=new PersonDetail()    //check the error

            //
            PersonDetail.A=10;
            PersonDetail.B=20;

            int reslt=PersonDetail.add();
            Console.WriteLine(reslt);


            



        }
    }
}
