using System;
using System.Collections.Generic;
namespace Dict;
class Program 
{
    public static void Main(string[] args)
    {
        Dictionary<int,string> value=new Dictionary<int, string>();
        value.Add(1,"gnanam");
        value.Add(2,"gokul");
        foreach(dynamic val in value)
        {
            System.Console.WriteLine($"key{val.key}  : value:{val.value}");
            //System.Console.WriteLine(value[1]);
           // string currentPerson=value[5];
            //value[1]="mani"; // update the value

        }
    }
}
