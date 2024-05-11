using System;
using System.Collections.Generic;


namespace SinglePractice
{
    public class Operation
    {
         static List<AadharDetail> aadharList=new List<AadharDetail>();
        public static void Register()
        {
            System.Console.WriteLine("Enter your BirthID");
            string birthID=Console.ReadLine();
            
            System.Console.WriteLine("Enter Your name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father name");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter Date of Birth");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your Adress");
            string address=Console.ReadLine();
            AadharDetail aadhar=new AadharDetail(birthID,name, fatherName, dob, address);
            aadharList.Add(aadhar);
            System.Console.WriteLine("Your Aadar id created: your Id is:"+aadhar.AadharID);
            System.Console.WriteLine("Your BirthID created : your id is "+aadhar.BirthID);

            foreach (AadharDetail aadar in aadharList)
            {
                System.Console.WriteLine($"{aadar.AadharID}  |  {aadar.BirthID}  |  {aadar.Name}  |  {aadar.FatherName}  |  {aadar.DOB.ToString("dd/MM/yyyy")}  |  {aadar.Address}");
            }

            
            
        }
    }
}
