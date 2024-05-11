using System;
namespace OverRiding 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Pomrian pomrian=new Pomrian();
            System.Console.WriteLine(pomrian.Sound());

            Animal animal=new Pomrian();
            System.Console.WriteLine(animal.Sound());
        }
    }
}
