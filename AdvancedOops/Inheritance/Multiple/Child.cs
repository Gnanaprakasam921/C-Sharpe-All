using System;

namespace Multiple
{
    public class Child : IFather,IMother
    {
        public void Dad()
        {
            System.Console.WriteLine("Dad method is called");
        }
        public void Mom()
        {
            System.Console.WriteLine("Mod method is called");
        }

        public void @on()
    }
}
