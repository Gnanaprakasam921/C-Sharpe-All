using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace EbBillCalculation
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
            List<EbBill> customerList = new List<EbBill>();
            string option = "";
            do
            {


                Console.WriteLine("For EB Bill Calcuation \n 1.Registeration.\n 2.Login \n 3.Exit ");
                int mainMenu = int.Parse(Console.ReadLine());
                switch (mainMenu)
                {
                    case 1:
                    
                        {
                            Console.WriteLine("Registeration");
                            Console.Write("Enter Your Name:");
                            string userName = Console.ReadLine();        
                            Console.Write("Enter Your Phone Number:");
                            long phone = long.Parse(Console.ReadLine());
                            Console.Write("Enter Your Email:");
                            string email = Console.ReadLine();
                           
                            EbBill customer = new EbBill(userName,  phone, email,0);
                            customerList.Add(customer);
                            Console.WriteLine("Custer ID Created:\n Your ID is:" + customer.MeterID);

                            break;
                        }


                    case 2:
                    {
                            Console.Write("Enter Your  Customer Id:");
                            string loginID = Console.ReadLine();
                            bool flag = true;
                            foreach (EbBill customer in customerList)
                            {
                                if (customer.MeterID == loginID)
                                {
                                    flag = false;
                                   
                                    do
                                    {
                                        //int deposite,balance=0;
                                        Console.WriteLine("1.Calculate menu 2.Display user detail 3. Exit");
                                        int submenu = int.Parse(Console.ReadLine());
                                        switch (submenu)
                                        {
                                            case 1:
                                                {

                                                    Console.Write("Enter your used unit:");
                                                    double UserName = double.Parse(Console.ReadLine());
                                                    customer.AmountCalc(amount);
                                                    System.Console.WriteLine(customer.amount);

                                                    break;
                                                }
                                            case 2:
                                                {
                                                    Console.WriteLine("Costomer Details:");
                                                    Console.WriteLine($"{customer.MeterID}\n{customer.UserName}\n{customer.Phone}\n{customer.Email}");
                                                    break;
                                                }
                                                case 3:
                                                {
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