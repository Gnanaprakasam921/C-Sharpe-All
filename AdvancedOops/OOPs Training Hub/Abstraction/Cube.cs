using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Cube : Shape
    {
         public Cube(double area, double volume, double radius, double height, double width)
        {
            Area=area;
            Volume=volume;
            Radius=radius;
            Height=height;
            Width=width;
        }

        public override double Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Volume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void CalculateArea(double radius, double height)
        {
            double pi=22/7;
            double area=4*pi*(radius+height);
           // return area;
        }

        public override void CalculateValme(double radius)
        {
            double pi=22/7;
            double Volume=pi*radius*6;
        }
    }
}