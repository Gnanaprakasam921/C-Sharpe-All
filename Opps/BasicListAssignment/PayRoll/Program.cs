using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace PayRollApplication
{
    class Program
    {
        public static void Main(string[] args)
        {


            List<PayRoll> employeeList = new List<PayRoll>();
            string option = "";
            do
            {


                Console.WriteLine("For Bank Account 1.Registeration.\n 2.Login \n 3.Exit ");
                int mainMenu = int.Parse(Console.ReadLine());
                switch (mainMenu)
                {
                    case 1:

                        {
                            Console.WriteLine("Employee Pay role Management");
                            Console.Write("Enter Your Name:");
                            string employeeName = Console.ReadLine();
                            Console.Write("Enter Your Role:");
                            string role = Console.ReadLine();
                            Console.Write("Enter your Work Location Chennai or USA or Kenya:");
                            WorkLocation workLocation = Enum.Parse<WorkLocation>(Console.ReadLine(), true);
                            Console.Write("Enter Your TeamName:");
                            string teamName = Console.ReadLine();
                            Console.Write("Enter Your Date Of Joining:");
                            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                            Console.Write("Enter Number of working day:");
                            int numberOfWorkingDay = int.Parse(Console.ReadLine());
                            Console.Write("Enter Number of Taken Leave:");
                            int numberOfLeaveTaken = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your Gender Male or Female:");
                            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
                            Console.Write("Dou you want continue:");
                            option = Console.ReadLine();

                            PayRoll employee = new PayRoll(employeeName, role, workLocation, teamName, dateOfJoining, numberOfWorkingDay, numberOfLeaveTaken, gender);
                            employeeList.Add(employee);
                            Console.WriteLine("Custer ID Created:\n Your ID is:" + employee.EmployeeID);

                            break;
                        }


                    case 2:
                        {
            
                            Console.Write("Enter Your  Customer Id:");
                            string loginID = Console.ReadLine();
                            bool flag = true;
                            foreach (PayRoll employee in employeeList)
                            {
                                if (employee.EmployeeID == loginID)
                                {
                                    flag = false;
                                    int a=10;

                                    do
                                    {
                                        //int deposite,balance=0;
                                        Console.WriteLine("1.Calculate Salary 2.Employee Detail 3.Exit");
                                        int submenu = int.Parse(Console.ReadLine());
                                        switch (submenu)
                                        {
                                            case 1:
                                                {

                                                    Console.Write("Your Salary:");

                                                    int result = employee.SalaryCalc(employee.NumberOfWorkingDay, employee.NumberOfLeaveTaken);
                                                    Console.WriteLine(result);

                                                    break;
                                                }
                                            case 2:
                                                {
                                                    Console.Write("Employee Detail:");
                                                    Console.WriteLine($"{employee.EmployeeName}\n{employee.EmployeeID}\n{employee.Gender}\n{employee.Role}\n{employee.WorkLocation}\n{employee.TeamName}\n{employee.DateOfJoining}\n{employee.NumberOfWorkingDay}\n{employee.NumberOfLeaveTaken}");

                                                    break;
                                                }
                                            case 3:
                                                {
                                                    a=20;
                                                    Console.WriteLine("Thank you");
                                                    break;
                                                }
                                        }


                                    } while (true);
                                }
                                if (flag)
                                {
                                    Console.WriteLine("invalid User Id:Try again!");
                                }

                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Thank You:");
                            break;
                        }
                }



            } while (option == "yes");






        }
    }
}