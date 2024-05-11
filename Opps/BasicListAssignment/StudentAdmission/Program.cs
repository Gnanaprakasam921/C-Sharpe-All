using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
namespace StudentAdmission
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            List<StudentRegister> studentList = new List<StudentRegister>();
            DateTime date1=new DateTime(1999,11,11);
            DateTime date2=new DateTime(1998,12,12);
            StudentRegister student1 = new StudentRegister("RaviChandran", "Ettaparajan", Gender.Male,date1, 95, 95, 95);
            studentList.Add(student1);
            StudentRegister student2 = new StudentRegister("Baskaran", "Sethurajan", Gender.Male, date2, 95, 95, 95);
            studentList.Add(student2);

            string option = "";
            do
            {
                Console.WriteLine("For Bank Account 1.Registeration.\n 2.Login \n 3.Exit ");
                int mainMenu = int.Parse(Console.ReadLine());
                switch (mainMenu)
                {
                    case 1:
                        {
                            Console.Write("STUDENT REGISERATION:");
                            Console.Write("Enter Your name:");
                            string studentName = Console.ReadLine();
                            Console.Write("Enter Your Father name:");
                            string fatherName = Console.ReadLine();
                            Console.WriteLine("Enter Your DOB:");
                            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                            Console.WriteLine("Enter your Gender Male or Female:");
                            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
                            Console.Write("Your Physics Mark:");
                            double physics = double.Parse(Console.ReadLine());
                            Console.Write("Your chemistry Mark:");
                            double chemistry = double.Parse(Console.ReadLine());
                            Console.Write("Your maths Mark:");
                            double maths = double.Parse(Console.ReadLine());
                            StudentRegister student = new StudentRegister(studentName, fatherName, gender, dob, physics, chemistry, maths);
                            studentList.Add(student);
                            Console.WriteLine("Student Registered Successfully and StudentID is " + student.StudentID);
                            Console.Write("Dou you want continue:");
                            option = Console.ReadLine();

                            //StudentRegister student



                            break;


                        }
                    case 2:
                        {
                            Console.Write("Enter Your  Customer Id:");
                            string loginID = Console.ReadLine();
                            bool flag = true;
                            foreach (StudentRegister student in studentList)
                            {
                                if (student.StudentID == loginID)
                                {
                                    flag = false;

                                    do
                                    {
                                        Console.WriteLine("1.Deposite 2.Withdrawn 3. Balance 4.Exit");
                                        int submenu = int.Parse(Console.ReadLine());
                                        switch (submenu)
                                        {
                                            case 1:
                                                {
                                                    bool isEligble = student.Eligibility();
                                                    if (isEligble)
                                                    {
                                                        Console.WriteLine("You are Eligible for the Admission");
                                                    }
                                                    else
                                                    {
                                                        System.Console.WriteLine("Not Elegible for Admission");
                                                    }


                                                    break;
                                                }


                                            case 2:
                                                {
                                                    Console.Write("Student Detatils:");
                                                    Console.WriteLine($"ID:{student.StudentID}\nName:{student.StudentName}\nFatherName:{student.FatherName}\nDOB:{student.DOB}\nGender:{student.Gender}\nPhysics Mark:{student.Physics}\nChemisty mark:{student.Chemistry}\nMaths mark:{student.Maths}");
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    break;
                                                }
                                        }


                                    } while (true);

                                }
                            }
                            if(flag)
                            {
                                Console.WriteLine("Invalid Id:");
                            }
                            
                            break;
                            
                        }

                }
            } while (option == "yes");
        }
    }
}
