using System;

namespace Outside
{
    public class Third
    {
        public int thirdpublic=30;
     internal int Thirdinternal=50;  

     protected internal int protectinternal=100;
    }
    public class Four
    {
        public void hello()
       {
        Third three=new Third();
        Console.WriteLine(three.protectinternal);
       } 
    }
}
