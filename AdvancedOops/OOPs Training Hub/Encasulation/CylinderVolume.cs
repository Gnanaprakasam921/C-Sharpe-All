using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume:CircleArea

    {
        private double _height;
        public double Height { get;set;}     

       // public int MyProperty { get; set; }
       internal double Volume{get;set;}
       public CylinderVolume()
       {
       // _height=height;
       // Volume=volume;
       }

       public double CalcVolume(int height)
       {
        double vol=CalcCircleArea(8)*height;
        return vol;
       }
    }
}