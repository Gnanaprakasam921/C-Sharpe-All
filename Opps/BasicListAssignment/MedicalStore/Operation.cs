using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace MedicalStore
{
    public class Operation
    {
        static List<UserDetail> userList = new List<UserDetail>();
        static List<MedicineDetails> medicineList = new List<MedicineDetails>();
        static List<OrderDetails> OrderList = new List<OrderDetails>();
        static UserDetail currentLoginUser;
        public static void AddDefaultData()
        {

            UserDetail user1 = new UserDetail("Ravi", 33, "Theni", 9877774440, 400);
            UserDetail user2 = new UserDetail("Baskaran", 33, "Chennai", 9877771240, 500);
            userList.Add(user1);
            userList.Add(user2);
            foreach (UserDetail user in userList)
            {
                System.Console.WriteLine($"{user.UserID,-15}  |  {user.UserName,-15}  |  {user.Age,-15}  |  {user.City,-15}  |  {user.Mobile,-15}  |  {user.Balance,-15}");
            }
            MedicineDetails medicine1 = new MedicineDetails("Paracitamol", 40, 5, new DateTime(2023, 12, 30));
            MedicineDetails medicine2 = new MedicineDetails("Calpol", 10, 5, new DateTime(2023, 11, 30));
            MedicineDetails medicine3 = new MedicineDetails("Gelucil", 3, 40, new DateTime(2024, 04, 30));
            MedicineDetails medicine4 = new MedicineDetails("Metrogel", 5, 50, new DateTime(2024, 12, 30));
            MedicineDetails medicine5 = new MedicineDetails("Povidin Iodin", 10, 50, new DateTime(2026, 10, 30));
            medicineList.Add(medicine1);
            medicineList.Add(medicine2);
            medicineList.Add(medicine3);
            medicineList.Add(medicine4);
            medicineList.Add(medicine5);
            foreach (MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine($"{medicine.MedicineID,-15}  |  {medicine.MedicineName,-15}  |  {medicine.AvailableCount,-15}  |  {medicine.Price,-15}  |  {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-15}");
            }
            OrderDetails order1 = new OrderDetails("UID1001", "MD2001", 3, 15, new DateTime(2023, 11, 13), OrderStatus.Purchases);
            OrderDetails order2 = new OrderDetails("UID1001", "MD2002", 2, 10, new DateTime(2023, 11, 13), OrderStatus.Cancelled);
            OrderDetails order3 = new OrderDetails("UID1001", "MD2004", 2, 100, new DateTime(2023, 11, 13), OrderStatus.Purchases);
            OrderDetails order4 = new OrderDetails("UID1002", "MD2003", 3, 120, new DateTime(2024, 01, 15), OrderStatus.Cancelled);
            OrderDetails order5 = new OrderDetails("UID1002", "MD2005", 5, 250, new DateTime(2024, 01, 15), OrderStatus.Purchases);
            OrderDetails order6 = new OrderDetails("UID1002", "MD2002", 3, 15, new DateTime(2024, 01, 15), OrderStatus.Purchases);
            OrderList.Add(order1);
            OrderList.Add(order2);
            OrderList.Add(order3);
            OrderList.Add(order4);
            OrderList.Add(order5);
            OrderList.Add(order6);
            foreach (OrderDetails order in OrderList)
            {
                System.Console.WriteLine($"{order.OrderID,-15}  |  {order.UserID,-15}  |  {order.MedicineID,-15}  |  {order.MedicineCount,-15}  |  {order.TotalPrice,-15}  |  {order.OrderDate.ToString("dd/MM/yyyy"),-15}  |  {order.OrderStatus,-15}");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Medical Shop Application");
                System.Console.WriteLine("1.User Registration\n2. User Login\n 3. Exit");
                int mainMenu = int.Parse(Console.ReadLine());
                switch (mainMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("Registration Selected");
                            Registr();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("login Selected");
                            Login();
                            break;
                        }

                    case 3:
                        {
                            System.Console.WriteLine("Exit Selected");
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }

        public static void Registr()
        {
            //  a.	Username
            // b.	Age
            // c.	City
            // d.	PhoneNumber
            // e.	Balance
            System.Console.WriteLine("User Registration:");
            System.Console.Write("Enter User Name:");
            string donerName = Console.ReadLine();
            System.Console.WriteLine("Enter Your age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your City:");
            string city = Console.ReadLine();
            System.Console.WriteLine("Enter your Phone:");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter amount for recharge:");
            double balance = double.Parse(Console.ReadLine());
            UserDetail user = new UserDetail(donerName, age, city, mobile, balance);
            Console.WriteLine(" Register Sucess fully and  Id is" + user.UserID);
            userList.Add(user);
            // Console.WriteLine("Do you want Continute:");
            //string option = Console.ReadLine();

        }
        public static void Login()
        {
            Console.WriteLine("Enter your user Id");
            string userID = Console.ReadLine().ToUpper();
            int flag = 1;
            foreach (UserDetail user in userList)
            {
                if (userID == user.UserID)
                {
                    flag = 0;
                    Console.WriteLine("Login Sucess Full");
                    currentLoginUser = user;
                    SubMenu();
                    break;

                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Invalid User Id.Please enter a valid one");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            Console.WriteLine("This is SubMenu");
            do
            {


                System.Console.WriteLine("a.Show medicine list.\nb.Purchase medicine: \n c.Cancel purchase. \n d.Show purchase history. \n e.Recharge \n f.ShowWalletBalance \n g. exit");
                char SubMenu = char.Parse(Console.ReadLine());
                switch (SubMenu)
                {
                    case 'a':
                        {
                            Console.WriteLine("Show medicine list.");
                            ShowMedicineList();

                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine("Purchase medicine");
                            PurchaseMedicine();

                            break;
                        }
                    case 'c':
                        {
                            System.Console.WriteLine("Cancel purchase.: ");
                            CancelPurchase();
                            break;
                        }

                    case 'd':
                        {
                            System.Console.WriteLine("Show purchase history.: ");
                            ShowPurchaseHistory();
                            break;
                        }
                    case 'e':
                        {
                            System.Console.WriteLine("Recharge: ");
                            Recharge();
                            break;
                        }
                    case 'f':
                        {
                            System.Console.WriteLine("Show WalletBalance: ");
                            ShowWalletBalance();
                            break;
                        }
                    case 'g':
                        {
                            Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }

                }
            } while (flag);
        }

        public static void ShowMedicineList()
        {
            //1.	Show the list of available medicine details in the store by traversing the medicine details list 
            foreach (MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine($"{medicine.MedicineID,-15}  |  {medicine.MedicineName,-15}  |  {medicine.AvailableCount,-15}  |  {medicine.Price,-15}  |  {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-15}");
            }
        }

        public static void PurchaseMedicine()
        {
            // 1.	Show the List of medicine details by traversing the medicine details list.
            foreach (MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine($"{medicine.MedicineID,-15}  |  {medicine.MedicineName,-15}  |  {medicine.AvailableCount,-15}  |  {medicine.Price,-15}  |  {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-15}");
            }

            // 2.	Ask the user to select the medicine using MedicineID.
            System.Console.WriteLine("Pleacse Medicine Medicine ID");
            string medicineID = Console.ReadLine();

            // 3.	Ask the number of counts of that medicine he wants to buy.
            System.Console.WriteLine("Plese Enter medicine count");
            int medicineCount = int.Parse(Console.ReadLine());
            // 4.	Check the Medicine list whether the MedicineID was available. If it is available, then 
            bool flag = true;
            foreach (MedicineDetails medicine1 in medicineList)
            {
                // a.	check the asked count is available. If it is available, then 

                if (medicine1.MedicineID == medicineID)
                {
                    flag = false;
                    if (medicine1.AvailableCount >= medicineCount)
                    {
                        // b.	Check the medicine was not expired
                        if (medicine1.DateOfExpiry > DateTime.Now)
                        {
                            // 7.	If all the conditions specified in step 4 are true then calculate the total amount of purchased medicines, OrderDate is Now, Put OrderStatus as “Purchased” and create object for OrderDetails class and add it to the list. 

                            double totalAmount = medicineCount * medicine1.Price;
                            if (totalAmount <= currentLoginUser.Balance)
                            {
                                // 5.	Reduce the number of AvailableCount of that medicine in MedicineDetails. 
                                medicine1.AvailableCount = medicine1.AvailableCount - medicineCount;
                                currentLoginUser.Balance = currentLoginUser.Balance - totalAmount;
                                OrderDetails order = new OrderDetails(currentLoginUser.UserID, medicineID, medicineCount, totalAmount, DateTime.Now, OrderStatus.Purchases);
                                OrderList.Add(order);
                                // 8.	Finally show the message “Medicine was purchased successfully”.
                                System.Console.WriteLine("Purchesed SucessFully");
                                break;
                            }
                            else
                            {
                                System.Console.WriteLine("You dont have balance for the purchues");
                            }

                        }
                        else
                        {
                            System.Console.WriteLine("Medicine Expied");
                        }
                    }
                    //If it is expired or not available, then show the user “Medicine is not available”.
                    else
                    {
                        System.Console.WriteLine("Medicine count not available:");
                    }
                }
            }

            if (flag)
            {
                System.Console.WriteLine("Invalid Medicine ID: Please Enter Valid.");
            }
        }
        public static void CancelPurchase()
        {
            // 1.	Show the order details of the currently logged in user whose order status is “Purchased”.
            foreach (OrderDetails order in OrderList)
            {
                if (currentLoginUser.UserID == order.UserID && order.OrderStatus == OrderStatus.Purchases)
                {
                    System.Console.WriteLine($"{order.OrderID,-15}  |  {order.UserID,-15}  |  {order.MedicineID,-15}  |  {order.MedicineCount,-15}  |  {order.TotalPrice,-15}  |  {order.OrderDate.ToString("dd/MM/yyyy"),-15}  |  {order.OrderStatus,-15}");
                }
            }

            // 2.	Get the OrderID information from the user
            System.Console.WriteLine("Enter Your orderID");
            string orderID = Console.ReadLine().ToUpper();
            // and check 
            bool flag = true;
            foreach (OrderDetails order1 in OrderList)
            {

                if (orderID == order1.OrderID && currentLoginUser.UserID==order1.UserID && order1.OrderStatus == OrderStatus.Purchases)
                {
                    //OrderID present //the  in the list and check its OrderStatus is Purchased.
                    //Change the Status of the order to “Cancelled”.
                    order1.OrderStatus = OrderStatus.Cancelled;
                    // 3.	If the OrderID matches increase the count of that Medicine in the medicine details, Return the amount to the user. 
                    foreach (MedicineDetails medicine in medicineList)
                    {
                        medicine.AvailableCount = medicine.AvailableCount + order1.MedicineCount;

                    }
                    currentLoginUser.Balance = currentLoginUser.Balance + order1.TotalPrice;
                    // 4.	Show the user that the “OrderID XXX was cancelled successfully”. 
                    System.Console.WriteLine($"OrderID {order1.OrderID} was cancelled successfully”");

                }
            }
            if (flag)
            {
                System.Console.WriteLine("You have not any order");
            }

        }
        public static void ShowPurchaseHistory()
        {
            //Show the purchased history of the current logged in user by traversing the OrderDetails list. 
            bool flag=true;
            foreach (OrderDetails order in OrderList)
            {
                if (currentLoginUser.UserID == order.UserID )
                {
                    flag=false;
                    System.Console.WriteLine($"{order.OrderID,-15}  |  {order.UserID,-15}  |  {order.MedicineID,-15}  |  {order.MedicineCount,-15}  |  {order.TotalPrice,-15}  |  {order.OrderDate.ToString("dd/MM/yyyy"),-15}  |  {order.OrderStatus,-15}");
                }
            }
            if(flag)
            {
                System.Console.WriteLine("No purchus History");
            }
        }
        public static void Recharge()
        {

            Console.Write("Enter your deposite amount:");
            int amount = int.Parse(Console.ReadLine());
            currentLoginUser.WalletRecharege(amount);
            //and update the balance information on his property.   
            System.Console.WriteLine(currentLoginUser.Balance);



        }
        public static void ShowWalletBalance()
        {
            //Display the user balance amount.

            Console.WriteLine("Your walletBalance:" + currentLoginUser.Balance);
        }


    }
}
