using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virctural1
{
    public class VolumeCalc : AreaCAl
    {
        public double Height { get; set; }
        public VolumeCalc(double radius,double height) : base(radius)
        {
            Height=height;

        }
        public override double Calc()
        {
            double pi=3.14;
             return pi*Radius*Radius*Height;
        }
         public override double Display()
        {
            return Calc();
        }
        
    }
 
}