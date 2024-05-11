using System;
using Hierarchical;
namespace Hierarchal 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            PrincipalInfo principalInfo=new PrincipalInfo("abc","fdjsk",98765,"jbdsf",new DateTime (2023,09,23),"male","mca",2,new DateTime(2134,09,03));
            System.Console.WriteLine(principalInfo.ShowPreinciapDetails());

            StudentInfo studentInfo =new StudentInfo("abc","fdjsk",98765,"jbdsf",new DateTime (2023,09,23),"male","mca","mca",4);
            System.Console.WriteLine(studentInfo.ShowStudetDetails());

             ClassTeacher classTeacher=new ClassTeacher("abc","fdjsk",98765,"jbdsf",new DateTime (2023,09,23),"male","mca","cs","mca",3,new DateTime (2023,09,23));
            System.Console.WriteLine(classTeacher.ShowTeacherDetails());
        }
    }
}