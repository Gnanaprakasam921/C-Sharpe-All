using System;
using Partial2;
namespace Partial;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo studentInfo=new StudentInfo("Gnanam","male",new DateTime(2023,07,28),98765,98,87,78);

        System.Console.WriteLine(studentInfo.Display());
    }
}