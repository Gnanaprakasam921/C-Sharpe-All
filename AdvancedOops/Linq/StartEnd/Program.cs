using System;
using System.Linq;
using System.Runtime.InteropServices;
namespace StartEnd;
class Program
{
    public static void Main(string[] args)
    {
        string[] area=new string[] {"ABU", "DHABI", "AMSTERDAM","ROME","MADURAI", "LONDON", "NEW DELHI" ,"MUMBAI", "NAIROBI"};
        System.Console.WriteLine("Enter Start Letter");
        char st=char.Parse(Console.ReadLine());
     
        System.Console.WriteLine("Enter the End Letter");
        char end=char.Parse(Console.ReadLine());
   

        var result=from i in area
                            where i.StartsWith(st)
                            where i.EndsWith(end)
                            select i;

        foreach(var city in result)
        {
            System.Console.WriteLine(city);
        }

    }
}