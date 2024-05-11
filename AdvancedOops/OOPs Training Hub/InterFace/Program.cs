using System;
namespace InterFace;
class Program 
{
    public static void Main(string[] args)
    {
     Dog dog=new Dog("pomerian", "Wow wow", "though"); 
     IAnimal animal=new Dog("pomerian", "Wow wow", "though");
     System.Console.WriteLine(animal.Name);
       
    }
}
