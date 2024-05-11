using System;
namespace Poly8;
class Porgram 
{
     public static void Main(string[] args)
    {
        Calculator sem1=new Calculator(89,78,98,67);
        System.Console.WriteLine($"Sem 1:Total:{sem1.Total()} Percentage:{sem1.Percentage()}");
        Calculator sem2=new Calculator(80,72,91,65);
        System.Console.WriteLine($"Sem 1: Total:{sem2.Total()} Percentage:{sem2.Percentage()}");
        Calculator sem3=new Calculator(69,38,78,57);
        System.Console.WriteLine($"Sem 1: Total:{sem3.Total()} Percentage:{sem3.Percentage()}");
        Calculator sem4=new Calculator(67,98,24,56);
        System.Console.WriteLine($"Sem 1: Total:{sem4.Total()} Percentage:{sem4.Percentage()}");

        Calculator total=new Calculator(sem1.Total(),sem2.Total(),sem3.Total(),sem4.Total());
        System.Console.WriteLine(total.Total());
        System.Console.WriteLine(total.Percentage());

        



    }
}
