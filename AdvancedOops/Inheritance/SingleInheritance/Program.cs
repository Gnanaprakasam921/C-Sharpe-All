using System;
namespace SingleInheritance
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Reactangle rect=new Reactangle();
            rect.height=10;
            rect.width=20;
            rect.shapeName="Reatanlge";
            rect.Dimentiosn();
            rect.Area();
        }
    }
}
