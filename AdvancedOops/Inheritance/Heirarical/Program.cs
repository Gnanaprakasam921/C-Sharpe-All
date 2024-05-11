using System;
namespace Heirarical 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Son son=new Son();
            Daughter daughter=new Daughter();
            son.Dad();
            son.Boy();
            daughter.Dad();
            daughter.Girl();
        }
    }
}
