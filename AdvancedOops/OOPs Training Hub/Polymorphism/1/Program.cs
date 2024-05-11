using System;
namespace polyq
{
    class Program 
    {
        public static void Main(string[] args)
        {
           // System.Console.WriteLine(Square(5));
            // System.Console.WriteLine(Square(5,4));
            // System.Console.WriteLine(Square(5,4,3));
            // System.Console.WriteLine(Square(6,9.4));
            // System.Console.WriteLine(Square(5,4.6,7.2f));
            System.Console.WriteLine(Squre1(5));
            System.Console.WriteLine(Squre1(4.9));
            System.Console.WriteLine(Squre1(7.4f));
            System.Console.WriteLine(Squre1(5L));
            
        }

        public  static int Squre(int a)
        {
            return a*a;
        }
        public static int Square(int a, int b)
        {
            return a*b;
        }
        public static int Squre(int a, int b, int c)
        {
            return a*b*c;
        }
        public static double Square(int a, double b)
        {
            return a*b;
        }
          public static double Square(int a, double b, float c)
        {
            return a*b*c;
        }


        public static int Squre1(int num)
        {
            return num*num;
        }

        public static double Squre1(double num)
        {
            return num*num;
        }

        public static float Squre1(float num)
        {
            return num*num;
        }

        public static long Squre1(long num)
        {
            return num*num;
        }

    }
}
