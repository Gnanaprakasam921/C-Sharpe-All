using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly8
{
    public class Calculator
    {
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Mark4 { get; set; }

        public Calculator(int mark1, int mark2, int mark3, int mark4)
        {
            Mark1=mark1;
            Mark2=mark2;
            Mark3=mark3;
            Mark4=mark4;
        }

        public int Total()
        {
            int total=Mark1+Mark2+Mark3+Mark4;
            return total;
        }
        public double Percentage()
        {
            double percent=Total()/4;
            return percent;
        }

    }
}