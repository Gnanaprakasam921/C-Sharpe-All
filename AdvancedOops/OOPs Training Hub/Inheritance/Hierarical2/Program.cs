using System;
namespace Hierarical2;
class Program 
{
    public static void Main(string[] args)
    {
        TemproryEmp temproryEmp=new TemproryEmp(1000,1,"kfdsh");
        System.Console.WriteLine(temproryEmp.Total());
        PermenentEmp permenentEmp=new PermenentEmp(1000,1,"jfdsh");
        System.Console.WriteLine(permenentEmp.Total());
        
    }
}
