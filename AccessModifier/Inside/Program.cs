using System;
using Outside;
namespace Inside
{
    class Program 
    {
        public static void Main(string[] args)
        {
            // public access modifier
             First one=new First();
             Console.WriteLine(one.publicnumber);

             
             // display private ele using property
             Console.WriteLine(one.Privateout);


// private can't access anonther class
            // Console.WriteLine(one.Privatenum);


            //internal
            Third three=new Third();
            Console.WriteLine(three.thirdpublic);
            //Console.WriteLine(three.thriedinternal)
        }
    }
}
