using System;
using CalculatorApp;
using MathsLib;
namespace Encasulation;
class Program 
{
    public static void Main(string[] args)
    {
        // CircleArea circleArea=new CircleArea(7);
        // System.Console.WriteLine(circleArea.CalcCircleArea());
        // CylinderVolume cylinderVolume=new CylinderVolume(12,14,19);
        // System.Console.WriteLine(cylinderVolume.CalcVolume());

        Maths maths=new Maths();
        System.Console.WriteLine(maths.CalculateWeight(78));
        CircleArea circleArea=new CircleArea();
        System.Console.WriteLine(circleArea.CalcCircleArea(7));
        CylinderVolume cylinderVolume=new CylinderVolume();
        System.Console.WriteLine(cylinderVolume.CalcVolume(9));
    }
}