using System;

namespace Inside
{
    public class First
    {
        public int publicnumber=10;
        private int privatenum=20;

        //Create property for privatenum
        public int Privateout { get{return privatenum;} }
    }
    public class Second
    {
        public void SecondMethod()
        {
            First one=new First();
            Console.WriteLine(one.publicnumber);

            //private can't access anther calss

            //Console.WriteLine(one.Privatenum);

        }
    }
}
