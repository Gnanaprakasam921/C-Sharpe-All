using System;
namespace Abstract3;
class Program 
{
    public static void Main(string[] args)
    {
        
        Car car1=new MaruthiSwift("Diesel",8,100000,"Sedan");
        System.Console.WriteLine(car1.DispalyCarDetails());
        Car car2=new SuzukiCiaz("Desel",6,97265,"suv");
        System.Console.WriteLine(car2.DispalyCarDetails());
    
    }
}
