using System;
namespace Deligates;
class Program 
{
    public delegate int Compute(int a, int b);
    public static void Main(string[] args)
    {
        Compute gp=new Compute(sum);
        System.Console.WriteLine(gp(12,13));
       // System.Console.WriteLine(sum(10,15));
         Compute gp1=new Compute(Mul);
        System.Console.WriteLine(gp1(12,13));
    }

    public static int sum(int a, int b)
    {
        int result=a+b;
        return result;
    }
    public static int Mul(int a, int b)
    {
        int result=a*b;
        return result;
    }
}