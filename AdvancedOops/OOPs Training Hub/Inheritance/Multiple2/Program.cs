using System;
namespace Multiple2;
class Program 
{
    public static void Main(string[] args)
    {
        ShiftDezire shiftDezire=new ShiftDezire("Petrol",4,"black",87,98,9876,9876,"kjh","kjhg");
        System.Console.WriteLine(shiftDezire.ShowDetails());
        Eco eco=new Eco("Petrol",4,"black",87,98,9876,9876,"kjh","kjhg");
        System.Console.WriteLine(eco.ShowDetails());

    }
}