using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virctual2
{
    public class Sphere:Dimention
    {
       

        public double Radius { get; set; }
         public Sphere(double value1) : base(value1)
        {
            Radius=value1;
            
        }
        public override double VCal()
        {
            return 4*3.14*Radius*Radius;
        }

        public override double Display()
        {
            return VCal();

            }
        }
    }
