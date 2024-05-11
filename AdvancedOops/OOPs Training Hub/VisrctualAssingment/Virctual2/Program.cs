using System;
namespace Virctual2;
class Program 
{
    public static void Main(string[] args)
    {
      // Dimention dimention=new Dimention();
      // System.Console.WriteLine(dimention.Display());
       Reactangle reactangle=new Reactangle(9,5);
       System.Console.WriteLine(reactangle.Display());
       Sphere sphere=new Sphere(6);
       System.Console.WriteLine(sphere.Display());

    }
}
