using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace BankingApplication
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Console.WriteLine("Bank Account Opening");
            // //Console.Write("Enter Couster Id:");
            // //int CustamerID=int.Parse(Console.ReadLine());
            // Console.Write("Enter Your Name:");
            // string name=Console.ReadLine();
            // Console.Write("Enter Your Balance");
            // long Balance=long.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your Gender Male or Female:");
            // Gender Gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            // Console.Write("Enter Your Phone Number:");
            // long Phone=long.Parse(Console.ReadLine());
            // Console.Write("Enter Your Email:");
            // string Email=Console.ReadLine();
            // Console.WriteLine("Enter Your DOB:");
            // DateTime DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            List<BankAccount> customerList = new List<BankAccount>();
            string option = "";
            bool temp=true;
            do
            {


                Console.WriteLine("For Bank Account 1.Registeration.\n 2.Login \n 3.Exit ");
                int Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                    
                        {
                            Console.WriteLine("Bank Account Opening");
                            Console.Write("Enter Your Name:");
                            string customerName = Console.ReadLine();
                            //Console.Write("Enter Your Balance");
                            Console.WriteLine("Enter your Gender Male or Female:");
                            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
                            Console.Write("Enter Your Phone Number:");
                            long phone = long.Parse(Console.ReadLine());
                            Console.Write("Enter Your Email:");
                            string email = Console.ReadLine();
                            Console.WriteLine("Enter Your DOB:");
                            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                            BankAccount customer = new BankAccount(customerName, gender, phone, email, dob, 0);
                            customerList.Add(customer);
                            Console.WriteLine("Custer ID Created:\n Your ID is:" + customer.CustomerID);
                            Console.Write("Dou you want continue:");
                            option=Console.ReadLine();a

                            break;
                        }


                    case 2:
                    {
                            Console.Write("Enter Your  Customer Id:");
                            string loginID = Console.ReadLine();
                            bool flag = true;
                            foreach (BankAccount customer in customerList)
                            {
                                if (customer.CustomerID == loginID)
                                {
                                    flag = false;
                                   
                                    do
                                    {
                                        //int deposite,balance=0;
                                        Console.WriteLine("1.Deposite 2.Withdrawn 3. Balance 4.Exit");
                                        int submenu = int.Parse(Console.ReadLine());
                                        switch (submenu)
                                        {
                                            case 1:
                                                {

                                                    Console.Write("Enter your deposite amount:");
                                                    double amount = double.Parse(Console.ReadLine());
                                                    customer.Deposite(amount);
                                                    System.Console.WriteLine(customer.Balance);

                                                    break;
                                                }
                                            case 2:
                                                {
                                                    Console.Write("Enter your withdrawal amount:");
                                                    double amount = double.Parse(Console.ReadLine());
                                                    bool isSuccess = customer.Withdrawn(amount);
                                                    if (isSuccess)
                                                    {
                                                        System.Console.WriteLine("Withdrawal successful");
                                                        System.Console.WriteLine("BALANCE:"+customer.Balance);
                                                    }
                                                    else
                                                    {
                                                        System.Console.WriteLine("Insufficient funds.");
                                                        System.Console.WriteLine("Your Balance:"+customer.Balance);
                                                    }
                                                    break;
                                                }
                                                case 3:
                                                {
                                                    Console.WriteLine("Your Balance:"+customer.Balance);
                                                    break;
                                                }
                                                case 4:
                                                {
                                                    temp=false;
                                                    Console.WriteLine("Thank You: Back to main menu:");
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
                    case 3:
                    {
                        temp=false;
                        Console.WriteLine("Thank You:");
                        break;
                    }
                }



            } while (option == "yes" && temp==true);
            Console.ReadLine();






        }
    }
}