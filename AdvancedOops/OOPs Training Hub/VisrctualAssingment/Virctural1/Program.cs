using System;
using Virctural1;
namespace Vircutal1;
class Program 
{
    public static void Main(string[] args)
    {
        AreaCAl areaCAl=new AreaCAl(6);
        System.Console.WriteLine(areaCAl.Display());
        VolumeCalc volumeCalc=new VolumeCalc(6,7);
        System.Console.WriteLine(volumeCalc.Display());
    }
}
