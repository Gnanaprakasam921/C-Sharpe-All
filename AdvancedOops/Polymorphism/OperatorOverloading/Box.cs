using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Box
    {
        private int _length;
        private int _hight;
        private int _width;

        public Box()
        {

        }
        public Box(int length, int width, int hight)
        {
            _length=length;
            _width=width;
            _hight=hight;
        }

        public double Calvolume()
        {
            return _length*_width*_hight;
        }

        // operator overloding must have pusblic and static

        public static Box Operator+(Box box1,Box Box2)
        {
            Box box=new Box();
            box._length=box1._length+box2._length;
            box._hight=box1._hight;
            box3._width=box1._width;
        }
    }
}