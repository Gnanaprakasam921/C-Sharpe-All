using System;
namespace Poly6;
class Program 
{
    public static void Main(string[] args)
    {
        Bank bank=new SBI();
        System.Console.WriteLine(bank.GetIntrest());
        Bank bank1=new ICCI();
        System.Console.WriteLine(bank.GetIntrest());
        Bank bank2=new HDFC();
        System.Console.WriteLine(bank.GetIntrest());
        Bank bank3=new IDBI();
        System.Console.WriteLine(bank.GetIntrest());

    }
}
