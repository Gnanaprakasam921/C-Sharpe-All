using System;
using Abstract2;
namespace Abstract;
class Program 
{
    public static void Main(string[] args)
    {
        EEE eEE=new EEE("fdsj","hsfdk","khsfhd",2022);
        EEE eEE1=new EEE("fshd","ugwhsfd","ura",87);
        System.Console.WriteLine(eEE.Display());
        System.Console.WriteLine(eEE1.Display());
        CSE cSE=new CSE("avc","wert","efdvbn",3647);
        System.Console.WriteLine(cSE.Display());
    }
}