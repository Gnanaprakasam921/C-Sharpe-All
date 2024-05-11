using System;
using Poly7;
namespace Ploy7;
class Program 
{
    public static void Main(string[] args)
    {
        Attendence month1=new Attendence(30,4,2);
        System.Console.WriteLine(month1.Calc());
          Attendence month2=new Attendence(30,4,4);
        System.Console.WriteLine(month2.Calc());
    }
}
