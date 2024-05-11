using System;
namespace InterFace2;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo studentInfo=new StudentInfo("dsjfh","fksdh",98765);
        System.Console.WriteLine(studentInfo.Display());
        EmployeeInfo employeeInfo=new EmployeeInfo("kjf","kfj");
        System.Console.WriteLine(employeeInfo.Display());
        
    }
}
