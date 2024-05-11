using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Shape
    {
        public abstract double Area { get; set; }
        public abstract double Volume { get; set; }

        public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public abstract void CalculateArea(double radius, double height);
        public abstract void CalculateValme(double radius);

    }
}