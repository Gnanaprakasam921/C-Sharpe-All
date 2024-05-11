using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed4
{
    public class CircleCalc : Calculaor
    {
        sealed override void Area(double r)
        {
            return 3.14*r*r;
        }

        public override void Volume()
        {
           
        }
    }
}