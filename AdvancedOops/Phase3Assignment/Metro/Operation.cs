using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Metro
{
    public class Operation
    {
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<TravelDetails> travelList = new CustomList<TravelDetails>();
        public static CustomList<TicketFairDetails> ticketList = new CustomList<TicketFairDetails>();
        public static UserDetails currentLoginUser;


        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Rivi", 9876543210, 1000);
            UserDetails user2 = new UserDetails("baskarn", 9826373890, 2000);
            userList.Add(user1);
            userList.Add(user2);
            foreach (UserDetails user in userList)
            {
                System.Console.WriteLine($"{user.CardNumber}  |  {user.Name}  |  {user.Phone}  |  {user.Balance}");

            }
            TravelDetails travel1 = new TravelDetails("CMR1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55);
            TravelDetails travel2 = new TravelDetails("CMR1001", "Egmore", "Koyambedu", new DateTime(2023, 10, 10), 32);
            TravelDetails travel3 = new TravelDetails("CMR1002", "Alandur", "Koyambedu", new DateTime(2023, 10, 10), 25);
            TravelDetails travel4 = new TravelDetails("CMR1002", "Egmore", "Thirumangalam", new DateTime(2023, 10, 10), 25);
            travelList.Add(travel1);
            travelList.Add(travel2);
            travelList.Add(travel3);
            travelList.Add(travel4);

            foreach (TravelDetails travel in travelList)
            {
                System.Console.WriteLine($"{travel.TravelledID}  |  {travel.CardNumber}  |  {travel.FromLocation}  |  {travel.ToLocation}  |  {travel.Date}  |  {travel.TravelCost}");

            }
            TicketFairDetails ticket1 = new TicketFairDetails("Airport", "Egmore", 55);
            TicketFairDetails ticket2 = new TicketFairDetails("Airport", "Koyambedu", 25);
            TicketFairDetails ticket3 = new TicketFairDetails("Alandur", "Koyambedu", 25);
            TicketFairDetails ticket4 = new TicketFairDetails("Koyambedu", "Egmore", 32);
            TicketFairDetails ticket5 = new TicketFairDetails("Vadapalani", "Egmore", 45);
            TicketFairDetails ticket6 = new TicketFairDetails("Arumbakkam", "Egmore", 25);
            TicketFairDetails ticket7 = new TicketFairDetails("Vadapalani", "Koyambedu", 25);
            TicketFairDetails ticket8 = new TicketFairDetails("Arumbakkam", "Koyambedu", 16);
            ticketList.Add(ticket1);
            ticketList.Add(ticket2);
            ticketList.Add(ticket3);
            ticketList.Add(ticket4);
            ticketList.Add(ticket5);
            ticketList.Add(ticket6);
            ticketList.Add(ticket7);
            ticketList.Add(ticket8);
            foreach (TicketFairDetails ticketFair in ticketList)
            {
                System.Console.WriteLine($"{ticketFair.TicketID}  |  {ticketFair.FromLocation,-15}  {ticketFair.ToLocation,-15}  |  {ticketFair.TicketPrice}");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("1.New Registeration  2. LoginUser  3.Exit");
                System.Console.WriteLine("Select Menu");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Registeration");
                            Registeration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Login");
                            Login();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exited");
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void Registeration()
        {
            System.Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your Mobile");
            long phone = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Balance");
            double balance = double.Parse(Console.ReadLine());
            UserDetails user = new UserDetails(name, phone, balance);
            userList.Add(user);
            System.Console.WriteLine("Register SucessFully: Your CardNumber :" + user.CardNumber);

        }

        public static void Login()
        {
            //bool flag=true;
            // System.Console.WriteLine("Enter your CardNumber");
            // string cardNumber=Console.ReadLine().ToUpper();
            // UserDetails currentLoginUser=Searching.LoginSearch(cardNumber);
            // if(currentLoginUser!=null)
            // {
            //     System.Console.WriteLine("Login Sucessfull");
            //     SubMenu();
            // }
            // else
            // {
            //     System.Console.WriteLine("User ID invalid");
            // }

            bool flag = true;
            System.Console.WriteLine("Enter the CardNumber:");
            string cardNumber = Console.ReadLine().ToUpper();

            foreach (UserDetails user in userList)
            {
                if (cardNumber == user.CardNumber)
                {
                    flag = false;
                    Console.WriteLine("Login Sucess Full");
                    currentLoginUser = user;
                    SubMenu();
                    break;

                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid User Id");
            }
        }

        public static void SubMenu()
        {
            bool flag = true;
            do
            {


                System.Console.WriteLine("1.Balance Check  2.Recharge  3. ViewTravel History  4. Travel  5. Exit");
                int subMenu = int.Parse(Console.ReadLine());
                switch (subMenu)
                {
                    case 1:
                        {
                            System.Console.WriteLine("BalanceCheck");
                            BalanceCheck();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Recharge");
                            Recharge();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("View Traval History");
                            ViewTravelHistory();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("Travel");
                            Travel();
                            break;
                        }
                    case 5:
                        {
                            System.Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }
                }
            } while (flag);


        }

        public static void BalanceCheck()
        {
            //Display the balance amount of the user object which is related to the card number.
            System.Console.WriteLine(currentLoginUser.Balance);

        }

        public static void Recharge()
        {
            //Get the amount to be recharged and add the recharged amount to the balance amount of the user object which is related to the card number.
            System.Console.WriteLine("Enter Amount for the Recharge:");
            double amount = double.Parse(Console.ReadLine());
            currentLoginUser.WalletRecharge(amount);
            System.Console.WriteLine("Recharge SucessFully: Your Balance" + currentLoginUser.Balance);


        }
        public static void ViewTravelHistory()
        {
            //Display list of the travel history objects which is related to the card number.
            foreach (TravelDetails travel in travelList)
            {
                if (currentLoginUser.CardNumber == travel.CardNumber)
                {
                    System.Console.WriteLine($"{travel.TravelledID}  |  {travel.CardNumber}  |  {travel.FromLocation}  |  {travel.ToLocation}  |  {travel.Date.ToString("dd/MM/yyyy")}  |  {travel.TravelCost}");
                }
            }

        }
        public static void Travel()
        {
            // 1.	Show the Ticket fair details where the user wishes to travel by getting TicketID.
            foreach (TicketFairDetails ticketFair in ticketList)
            {
                System.Console.WriteLine($"{ticketFair.TicketID}  |  {ticketFair.FromLocation,-15}  {ticketFair.ToLocation,-15}  |  {ticketFair.TicketPrice}");
            }

            System.Console.WriteLine("Enter the TicketID");
            string ticketID=Console.ReadLine();
            
            

            // 2.	Check the ticketID is valid. 
            // TicketFairDetails currentUser=Searching.TicketCheck(ticketID);
            //if(currentUser!=null)
            bool flag = true;
            foreach (TicketFairDetails ticket in ticketList)

            {
                if (ticket.TicketID == ticketID)
                {
                    flag = false;


                    // 3.	IF ticket is valid then, Check the balance from the user object whether it has sufficient balance to travel.
                    // foreach (TravelDetails travel in travelList)
                    // {
                        if (currentLoginUser.Balance>= ticket.TicketPrice)
                        {
                            // 4.	If “Yes” deduct the respective amount from the balance and add the travel details like Card number, From and ToLocation, Travel Date, Travel cost, Travel ID (auto generation) in his travel history.
                            currentLoginUser.Balance = currentLoginUser.Balance - ticket.TicketPrice;
                            TravelDetails travel1 = new TravelDetails(currentLoginUser.CardNumber, ticket.FromLocation, ticket.ToLocation, DateTime.Now,ticket.TicketPrice);
                            travelList.Add(travel1);
                            System.Console.WriteLine("Travl booked: your Id is"+ticket.TicketID);
                            

                        }
                        else
                        {
                            System.Console.WriteLine("Insufficient Balance. Please Recharge");
               

                       // }
                    }
                }
                


            }
            // Else show “Invalid user id”.
            if (flag)
            {
                System.Console.WriteLine("Invalid ticketID");
            }






            // 5.	If “No” ask him to recharge and go to the “Existing User Service” menu.



        }
    }
}