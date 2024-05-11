using System;
using OperatorOverloading;
namespace OperatorOverLoading 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Box box1=new Box(10,20,30);
            Box box2=new Box(30,40,50);
            System.Console.WriteLine(box2.Calvolume());
            System.Console.WriteLine(box1.Calvolume());

            Box box=box1+box2;
        }
    }
}
