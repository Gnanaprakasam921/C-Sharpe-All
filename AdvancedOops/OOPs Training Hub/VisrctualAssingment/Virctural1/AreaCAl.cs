using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virctural1
{
    public class AreaCAl
    {
        public double Radius { get; set; }
        public AreaCAl(double radius)
        {
            Radius=radius;
        }
        public virtual double Calc()
        {
            double pi=3.14;
            return pi*Radius*Radius;

        }
        public virtual double Display()
        {
            return Calc();
        }
    }
}