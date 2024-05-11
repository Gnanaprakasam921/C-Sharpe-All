using System;
using System.Runtime.Intrinsics.Arm;
using System.Collections.Generic;
using CollegeAdmis;
namespace CollegeAdmission
{
    class Program 
    {
        public static void Main(string[] args)
        {
            ///  Code reuseablily for output.
          ///// 
          
          // List<StudentDetail> studentlist=new List<StudentDetail>();
          
          //   // Sudent 1

          //   StudentDetail student1=new StudentDetail();

          //   Console.Write("Enter Your Name:");
          //   student1.StudentName=Console.ReadLine();
          //   Console.Write("Enter Your Father Name");
          //   student1. FatherName=Console.ReadLine();
          //   Console.Write("Enter Your Gender");
          //   student1.Gender=Console.ReadLine();
          //   // Console.Write("Enter Your DOB");
          //   // student1.Dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
          //   // Console.Write("Tamil Mark:");
          //   // student1.Tamil=int.Parse(Console.ReadLine());
          //   // Console.Write("English Mark:");
          //   // student1.English=int.Parse(Console.ReadLine());

          //   // Console.Write("Maths Mark:");
          //   //  student1.Maths=int.Parse(Console.ReadLine());

          //   studentlist.Add(student1);

          //   StudentDetail student2=new StudentDetail();
          //    Console.Write("Enter Your Name:");
          //   student2.StudentName=Console.ReadLine();
          //   Console.Write("Enter Your Father Name");
          //   student2. FatherName=Console.ReadLine();
          //   Console.Write("Enter Your Gender");
          //   student2.Gender=Console.ReadLine();

          //   studentlist.Add(student2);

          //   StudentDetail student3=new StudentDetail();
          //    Console.Write("Enter Your Name:");
          //   student3.StudentName=Console.ReadLine();
          //   Console.Write("Enter Your Father Name:");
          //   student3. FatherName=Console.ReadLine();
          //   Console.Write("Enter Your Gender:");
          //   student3.Gender=Console.ReadLine();
 
          //   studentlist.Add(student3);

          //   foreach(StudentDetail student in studentlist)
          //   {
          //       Console.WriteLine($"{student.StudentName}\n{student.FatherName}\n{student.Gender}\n");
          //   }

          //    Console.WriteLine($"{student1.StudentName}\n{student1.FatherName}\n{student1.Gender}\n");
          //     //Console.WriteLine($"{student2.StudentName}\n{student2.FatherName}\n{student2.Gender}\n");
          //     //Console.WriteLine($"{student3.StudentName}\n{student3.FatherName}\n{student3.Gender}\n");


        //   List<StudentDetail> studentlist=new List<StudentDetail>();
        //   string option="";
        //   do
        //   {
        //       Console.WriteLine("Stident Registration form:");
        //       StudentDetail student1=new StudentDetail();
        //       Console.Write("Enter Your Name:");
        //      student1.studentname=Console.ReadLine();
        //      Console.Write("Enter Your Father Name:");
        //     student1. fathername=Console.ReadLine();
        //      Console.Write("Enter Your Gender:");
        //     student1.gender=Console.ReadLine();
        //     Console.Write("Dou you want continue:");
        //     option=Console.ReadLine();

        //   }while(option=="yes");
          

        //    foreach(StudentDetail student in studentlist)
        //     {
        //          Console.WriteLine($"{student.studentname}\n{student.fathername}\n{student.gender}\n");
        //     }
            


            //  Construtor with perameter

            List<StudentDetail> studentlist=new List<StudentDetail>();
          string option="";
          do
          {
            Console.WriteLine("Stident Registration form:");
           // StudentDetail student1=new StudentDetail();
            Console.Write("Enter Your Name:");
            string studentname=Console.ReadLine();
            Console.Write("Enter Your Father Name:");
            string fathername=Console.ReadLine();
            Console.Write("Enter Your Gender Male Female:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true); // Enum using
            Console.Write("Enter Your DOB:");
            DateTime Dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Tamil Mark:");
            int Tamil=int.Parse(Console.ReadLine());
            Console.Write("English Mark:");
            int English=int.Parse(Console.ReadLine());

            Console.Write("Dou you want continue:");
            option=Console.ReadLine();


            //Id increment
            

            // Perameterized constructor object

            StudentDetail student=new StudentDetail(studentname,fathername,gender,Dob,Tamil,English);

            studentlist.Add(student);

            Console.WriteLine("Your Id is:"+ student.studentID);

          }while(option=="yes");

          Console.WriteLine("Enter your login id");
          string loginID=Console.ReadLine();
          
          bool flag=true;


           foreach(StudentDetail student in studentlist)
            {
              if(student.studentID==loginID)
              {
                flag=false;
              
                 Console.WriteLine($"{student.studentname}\n{student.fathername}\n{student.gender}\n{student.tamil}\n{student.english}\n{student.studentID}");

                 // method calling
                 bool eligibility=student.check(75);
                 if(eligibility)
                 {
                  Console.WriteLine("pass");  
                 }
                 else{
                    Console.WriteLine("fail");
                 }
              }
            }
            if(flag)
            {
              Console.WriteLine("Invalid id");
            }

            // Destructor

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Code end");
            




        }
    }
}
