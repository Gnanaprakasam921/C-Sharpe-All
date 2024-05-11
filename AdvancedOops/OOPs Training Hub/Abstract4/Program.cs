using System;
namespace Abstract4;
class Program 
{
    public static void Main(string[] args)
    {
        Dress mens=new MensWear("Mens","pant",1000);
        System.Console.WriteLine(mens.DisplayInfo());
        Dress ladies=new LediesWear("Ledies","saree",2000);
        System.Console.WriteLine(ladies.DisplayInfo());
        
    }
}
