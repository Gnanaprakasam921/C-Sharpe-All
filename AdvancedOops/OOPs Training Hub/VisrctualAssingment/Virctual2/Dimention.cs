using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virctual2
{
    public class Dimention
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
       // public double Value3{get; set;}
        public double Area { get; set; }

        public Dimention(double value1, double value2)
        {
            Value1=value1;
           Value2=value2;
        }
        public Dimention(double value1)
        {
            Value1=value1;
        }

        public Dimention()
        {
        }

        public virtual double VCal()
        {
             
             return Value1*Value2;
        }
        public virtual double Display()
        {
            return VCal();
        }

    }
}