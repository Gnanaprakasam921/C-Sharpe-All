using System;
namespace Poly5;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails emp=new EmpInfo("Gananm","Sekar",98765,"Gnder");
        System.Console.WriteLine(emp.Dispaly());

        PersonalDetails personalDetails1=new SalaryInfo("Gnanam","sekar",98765,"Gender",25);
        System.Console.WriteLine(personalDetails1.Dispaly());


    }
}
