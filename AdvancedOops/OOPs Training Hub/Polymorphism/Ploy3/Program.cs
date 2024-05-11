using System;
namespace Poly3;
class Program 
{
    public static void Main(string[] args)
    {
        Squre squre=new Squre();
        System.Console.WriteLine(squre.Calc(4));
        System.Console.WriteLine(squre.Calc(4.4));
        System.Console.WriteLine(squre.Calc(8.4f));
        System.Console.WriteLine(squre.Calc(20000));

    }

    public class Squre
    {
        
        public double Calc(int a)
        {
            return a*a;
        }

         public double Calc(double a)
        {
            return a*a;
        }

         public float Calc(float a)
        {
            return a*a;
        }

         public long Calc(long a)
        {
            return a*a;
        }
    }
}
