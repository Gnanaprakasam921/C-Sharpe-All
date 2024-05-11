using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virctual2
{
    public class Reactangle:Dimention
    {
        public double Length { get; set; }
        public double Height { get; set; }
        
        public Reactangle(double length, double height):base(length,height)
        {
            Length=length;
            Height=height;
        }
        public override double VCal()
        {
            return Length*Height;
        }

        public override double Display()
        {
            return VCal();
        }
    }
}