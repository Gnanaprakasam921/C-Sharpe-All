using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea:Maths
    {
        protected double _radius;
        public double Radius { get; set; }
        internal double _area{get;set;}

        public CircleArea()
        {
           // _radius=radius;
           // _area=area;
        }

        public double CalcCircleArea(int radius)
        {
            double _area=_pi*(radius*radius);
            return _area;
        }

        


    }
}