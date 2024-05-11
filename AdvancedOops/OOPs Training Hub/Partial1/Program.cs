using System;
using Partial1;
namespace Partial;
class Program 
{
    public static void Main(string[] args)
    {
        EmpInfo empInfo=new EmpInfo("Gnanam","Male",new DateTime(2001,07,28),9876543);
        System.Console.WriteLine(empInfo.Dispaly());
    }
}
