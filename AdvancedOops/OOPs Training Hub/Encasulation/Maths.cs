using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        protected internal double _pi=3.14;
       // public double PI{get {return _pi;}}
        internal double _g=9.8;
        //public double G{get {return _g;}}

        // public Maths(double pi, double g)
        // {
        //     _pi=pi;
        //     _g=g;
        // }

          public Maths()
        {
            
        }


        public double CalculateWeight(double mass)
        {
            double weight=mass* _g;
            return weight;
        }
    }
}