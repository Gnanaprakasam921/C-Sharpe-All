using System;
using System.Collections.Generic;
using System.Linq;
namespace Sort;
class Program 
{
    public static void Main(string[] args)
    {
        string[] area=new string[] {"ABU", "DHABI", "AMSTERDAM","ROME","MADURAI", "LONDON", "NEW DELHI" ,"MUMBAI", "NAIROBI"};

        var order=area.OrderBy(order=>order.Length);
        foreach(var i in order)
        {
            System.Console.WriteLine(i);
        }
    }
}
