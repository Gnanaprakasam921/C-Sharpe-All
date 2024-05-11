using System;
namespace OverLoading 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            //overloading by number arguments
           // Add(10,20)
            Add(10,20,30);
            // Overloading by type

            Add("Gnanam",10);
            Add(10.5,89);

            System.Console.WriteLine(Add(10,20));
            
        }

        public static int Add(int a, int b)
        {
            return a+b;
        }
        public static int Add(int a, int b, int c)
        {
            return a+b+c;
        }

        public static string Add(string fN, int lN)
        {
            return fN+lN;
        }
        public static double Add(double a, int b)
        {
            return a+b;
        }
    }
}