using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace CafeteriaCard
{
    public partial class Operation
    {
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();
        public static List<FoodDetails> foodList = new List<FoodDetails>();
        public static List<CartItem> cartList = new List<CartItem>();
        static UserDetails currentUserLogin;


        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", 8857777575, "ravi@gmail.com", Gender.Male, "WS101", 400);
            UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", 9577747744, "baskaran@gmail.com", Gender.Male, "WS105", 500);

            userList.Add(user1);
            userList.Add(user2);
            foreach(UserDetails user in userList)
            {
                System.Console.WriteLine($"{user.UserID}  |  {user.Name,-15}  |  {user.FatherName,-20}  |  {user.Mobile}  |  {user.Mail,-15}  |  {user.Gender}  |  {user.WorkStationNumber}  | {user.WalletBalance}");
            }
            System.Console.WriteLine();
            FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
            FoodDetails food2 = new FoodDetails("Tea", 15, 100);
            FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
            FoodDetails food4 = new FoodDetails("Juice", 50, 100);
            FoodDetails food5 = new FoodDetails("Puff", 40, 100);
            FoodDetails food6 = new FoodDetails("Milk", 10, 100);
            FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);
            foreach (FoodDetails food in foodList)
            {
                System.Console.WriteLine($"{food.FoodID,-10}  |  {food.FoodName,-10}  |  {food.FoodPrice}  |  {food.AvailabilityCount}");
            }
            System.Console.WriteLine();

            OrderDetails order1 = new OrderDetails("SF1001", new DateTime(2022, 06, 15), 70, OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("SF1002", new DateTime(2022, 06, 15), 100, OrderStatus.Ordered);
            orderList.Add(order1);
            orderList.Add(order2);
            foreach (OrderDetails order in orderList)
            {
                System.Console.WriteLine($"{order.OrderID}  |  {order.UserID}  |  {order.OrderDate.ToString("dd/MM/yyyy")} | {order.OrderStatus}");
            }
            System.Console.WriteLine();
            CartItem cart1 = new CartItem("OID1001", "FID101", 20, 1);
            CartItem cart2 = new CartItem("OID1001", "FID103", 10, 1);
            CartItem cart3 = new CartItem("OID1001", "FID105", 40, 1);
            CartItem cart4 = new CartItem("OID1002", "FID103", 10, 1);
            CartItem cart5 = new CartItem("OID1002", "FID104", 50, 1);
            CartItem cart6 = new CartItem("OID1002", "FID105", 40, 1);
            cartList.Add(cart1);
            cartList.Add(cart2);
            cartList.Add(cart3);
            cartList.Add(cart4);
            cartList.Add(cart5);
            cartList.Add(cart6);
            foreach (CartItem cart in cartList)
            {
                System.Console.WriteLine($"{cart.ItemID}  |  {cart.OrderID}  |  {cart.FoodID}  |  {cart.OrderPrice}  |  {cart.OrderQuantity}");
            }

        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("1.Register \n2.Login \n3.Exit");
                System.Console.WriteLine("Enter the option");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            System.Console.WriteLine("New user Register for Login");
                            Register();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("IF you have an Id Login");
                            Login();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }
                }

            } while (flag);
        }

        public static void Register()
        {
            System.Console.WriteLine("Register this form for new user");
            // a.	Username
            // b.	Father Name
            // c.	Mobile Number
            // d.	MailID
            // e.	Gender 
            // f.	WorkStationNumber (WS101) 
            // g.	Balance
            System.Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your Father Name:");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter your mobile number:");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail id:");
            string mail = Console.ReadLine();
            System.Console.WriteLine("Enter your Gender:");
            Gender gender = Enum.Parse<Gender>((Console.ReadLine()), true);
            System.Console.WriteLine("Enter Work station number WS1001 to Ws1005:");
            string workStationNumber = Console.ReadLine();
            System.Console.WriteLine("Enter your Balance");
            double balance = double.Parse(Console.ReadLine());
            UserDetails user = new UserDetails(name, fatherName, mobile, mail, gender, workStationNumber, balance);
            userList.Add(user);
            System.Console.WriteLine($"Registration successfully!\n Your ID is:{user.UserID}");

        }

        public static void Login()
        {
            bool flag = true;
            System.Console.WriteLine("Enter your UserID");
            string userID = Console.ReadLine();

            foreach (UserDetails user in userList)
            {
                if (userID == user.UserID)
                {
                    flag = false;
                    System.Console.WriteLine("login successfull");
                    currentUserLogin = user;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Invalid User ID:");
            }

            // SubMenu();
        }


        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("1.ShowMyProfile \n2.FoodOrder \n3.ModifyOrder \n4.CancelOrder \n5.OrderHistory \n6.WalletRecharge \n7.ShowWalletBalance \n8.Exit");
                System.Console.WriteLine("Choose for Operation");
                int subMenu = int.Parse(Console.ReadLine());
                switch (subMenu)
                {
                    case 1:
                        {
                            System.Console.WriteLine("ShowMyProfile");
                            ShowMyProfile();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("FoodOrder");
                            FoodOrder();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("ModifyOrder");
                            ModifyOrder();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("CancelOrder");
                            CancelOrder();
                            break;

                        }
                    case 5:
                        {
                            System.Console.WriteLine("OrderHistory ");
                            OrderHistory();
                            break;

                        }
                    case 6:
                        {
                            System.Console.WriteLine("WalletRecharge");
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            System.Console.WriteLine("ShowWalletBalance");
                            ShowWalletBalance();
                            break;

                        }
                    case 8:
                        {
                            System.Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }
                }



            } while (flag);

        }

        public static void ShowMyProfile()
        {
            //Show the current logged in user’s personal details in console.

            foreach (UserDetails user in userList)
            {
                if (currentUserLogin.UserID == user.UserID)
                {
                    System.Console.WriteLine($"{user.UserID}  |  {user.Name,-15}  |  {user.FatherName,-20}  |  {user.Mobile}  |  {user.Mail,-15}  |  {user.Gender}  |  {user.WorkStationNumber}  | {user.WalletBalance}");
                }
            }
        }

        public static void FoodOrder()
        {
            // 1.	Create a temporary local carItemtList.
            List<CartItem> localCart = new List<CartItem>();
            // 2.	Create an Order object  //with current UserID, Order date as current DateTime, total price as 0, Order status as “Initiated”.
            OrderDetails order = new OrderDetails(currentUserLogin.UserID, DateTime.Now, 0, OrderStatus.Initiated);

            // 3.	Ask the user to pick a product using FoodID, quantity required and calculate price of food.
            string option;
            double totalPrice = 0;

            do
            {
                foreach (FoodDetails food in foodList)
                {
                    System.Console.WriteLine($"{food.FoodID,-10}  |  {food.FoodName,-10}  |  {food.FoodPrice}  |  {food.AvailabilityCount}");
                }
                System.Console.WriteLine("Enter the FoodID");
                string foodID = Console.ReadLine();
                System.Console.WriteLine("Enter the Quantity");
                int quantity = int.Parse(Console.ReadLine());
                bool flag = true;
                foreach (FoodDetails food1 in foodList)
                {
                    if (foodID == food1.FoodID)
                    {
                        flag = false;
                        if (quantity <= food1.AvailabilityCount)
                        {
                            // 4.	If the food and quantity available, reduce the quantity from the food object’s “AvailableQuantity” then create CartItems object using the available data.
                            double price = food1.FoodPrice * quantity;
                            food1.AvailabilityCount -= quantity;
                            totalPrice += price;

                            // 5.	Add that object it to local CartItemsList to add it to cart wish list.
                            CartItem cart = new CartItem(order.OrderID, food1.FoodID, price, quantity);
                            cartList.Add(cart);

                        }
                        else
                        {
                            System.Console.WriteLine("Food count Not available");
                        }


                    }
                }
                if (flag)
                {
                    System.Console.WriteLine("Invalid food ID");
                }

                // 6.	Ask the user whether he want to pick another product. 
                System.Console.WriteLine("Do you want to pick another product");
                option = Console.ReadLine();
                // 7.	If “Yes” then show the updated Food Details and repeat from step “3”.
                // 8.	Repeat the process until the user enters “No”.
            } while (option == "yes");
            // 9.	If He says No then, 
            // 10.	Ask the user whether he confirm the wish list to purchase. 
            System.Console.WriteLine("Do you confirm the wish list to purchase");
            string say = Console.ReadLine().ToLower();
            if (say == "yes")
            {
                // 11.	If he says “Yes” then, Calculate the total price of the food items selected using the local CartItemList information and check the balance from the user details whether it has sufficient balance to purchase.
                // 12.	If he has enough balance, then deduct the respective amount from the user’s balance. 
                bool temp = false;
                do
                {


                    if (totalPrice < currentUserLogin.WalletBalance)
                    {
                        temp = false;
                        // 13.	Append the local CartItemList to global CartItemList.
                        cartList.AddRange(localCart);
                        // 14.	Modify Order object created at step 1’s total price as total OrderPrice and OrderStatus as “Ordered”. 

                        order.OrderStatus = OrderStatus.Ordered;
                        order.TotalPrice = totalPrice;
                        currentUserLogin.DeductAmount(totalPrice);
                        // 15.	Then add the Order object to the Order list.
                        orderList.Add(order);
                        // 16.	Show “Order placed successfully, and OrderID is OID1001”.
                        System.Console.WriteLine("Order purchesed Sucessfully");
                    }
                    // 17.	If he doesn’t have enough balance show “In sufficient balance to purchase.” Ask him “Are you willing to recharge.”
                    else
                    {
                        System.Console.WriteLine("insufficent balance");
                        System.Console.WriteLine("Are you Willing to recharge");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "Yes")
                        {
                            // 19.	If he says “Yes”. Then ask him to Recharge with the total price of Order. If he recharged with that amount means continue from step 12 to continue purchase. 
                            temp = true;
                            System.Console.WriteLine("Enter the amount to Recharge");
                            double amount = double.Parse(Console.ReadLine());
                            currentUserLogin.WalletRecharge(amount);
                            System.Console.WriteLine("your Current balance:" + currentUserLogin.WalletBalance);

                        }
                        // 18.	 If he says “No” then show “Exiting without Order due to insufficient balance”. Then need to return the localCartList items to foodItemsList.

                        else
                        {
                            temp = false;


                            foreach (CartItem cart in localCart)
                            {
                                foreach (FoodDetails food in foodList)
                                {
                                    if (cart.FoodID == food.FoodID)
                                    {
                                        food.AvailabilityCount += cart.OrderQuantity;
                                        break;
                                    }
                                }

                            }
                        }
                    }
                } while (temp);
            }

            //If he says “No” then traverse the local CartItemList and get the Items one by one and reverse the quantity to the FoodItem’s objects in the foodList.
            else
            {
                foreach (CartItem cart in localCart)
                {
                    foreach (FoodDetails food in foodList)
                    {
                        if (cart.FoodID == food.FoodID)
                        {
                            food.AvailabilityCount += cart.OrderQuantity;
                            break;
                        }
                    }
                }
            }







        }
        public static void ModifyOrder()
        {

            // 1.	Show the Order details of current logged in user to pick an Order detail by using OrderID and whose status is “Ordered”
            bool temp1 = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentUserLogin.UserID == order.UserID && order.OrderStatus == OrderStatus.Ordered)
                {
                    temp1 = false;
                    System.Console.WriteLine($"{order.OrderID}  |  {order.UserID}  |  {order.OrderDate.ToString("dd/MM/yyyy")} | {order.OrderStatus}");
                }
            }
            if (temp1)
            {
                System.Console.WriteLine("You no any Order");
            }
            else
            {
                //Check whether the order details is present. If yes then,
                System.Console.WriteLine("Enter Order ID to modify:");
                string orderID = Console.ReadLine();
                bool flag = true;
                double itemPrice = 0;
                foreach (OrderDetails order1 in orderList)
                {


                    if (orderID == order1.OrderID && order1.OrderStatus == OrderStatus.Ordered)
                    {
                        
                        flag = false;
                        // 2.	Show list of Cart Item details //and ask the user to pick an Item id.
                        foreach (CartItem cart1 in cartList)
                        {
                            if (cart1.OrderID == order1.OrderID)
                            {


                                System.Console.WriteLine($"{cart1.ItemID}  |  {cart1.OrderID}  |  {cart1.FoodID}  |  {cart1.OrderPrice}  |  {cart1.OrderQuantity}");

                            }
                        }


                        System.Console.WriteLine("Enter the Item ID");
                        string itemID = Console.ReadLine();

                        bool temp = true;

                        foreach (CartItem cart in cartList)
                        {

                            // 3.	Ensure the ItemID is available and ask the user to enter the new quantity of the food.
                            if (itemID == cart.ItemID)
                            {

                                temp = false;

                                System.Console.WriteLine("Enter the new quatitiy:");
                                int quantity = int.Parse(Console.ReadLine());
                                bool temp2=true;
                                foreach (FoodDetails food in foodList)
                                {
                                    // if ()
                                    // {


                                    if (quantity < food.AvailabilityCount && food.FoodID == cart.FoodID)
                                    {
                                        temp2=false;
                                        int finalQuantity=quantity-cart.OrderQuantity;
                                        if(finalQuantity==0)
                                        {
                                            System.Console.WriteLine("same quantity");
                                        }
                                        else if(finalQuantity<0)
                                        {
                                            cart.OrderQuantity+=finalQuantity;
                                            double returnAmount=-finalQuantity*food.FoodPrice;
                                            currentUserLogin.WalletRecharge(returnAmount);
                                            food.AvailabilityCount+=-finalQuantity;
                                            System.Console.WriteLine("orderModified sucessfully");
                                            
                                        }
                                        else
                                        {
                                            double returnAmount=finalQuantity*food.FoodPrice;
                                            if(currentUserLogin.WalletBalance>returnAmount)
                                            {
                                                cart.OrderQuantity+=finalQuantity;
                                                currentUserLogin.DeductAmount(returnAmount);
                                                food.AvailabilityCount-=finalQuantity;
                                                System.Console.WriteLine("orderModified Sucessfully");

                                            }
                                            else
                                            {
                                                System.Console.WriteLine("Insuffificient Balance");
                                            }
                                        }
                                        
                                        
                                     
                                        //Calculate the Item price and update in the OrderPrice.
                                         itemPrice = quantity * food.FoodPrice;
                                          if (itemPrice <= currentUserLogin.WalletBalance)
                                        {
                                               food.AvailabilityCount = food.AvailabilityCount - quantity;
                                               currentUserLogin.DeductAmount(itemPrice);
                                               cart.OrderQuantity=quantity;

                                            // 4.	Calculate the total price of Items and update in Order details entry. 
                                                //order1.TotalPrice += itemPrice;
                                            // 5.	Show Order modified successfully.
                                            System.Console.WriteLine("Modified Sucessfully");
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("insufficient Balance! Please Recharge");
                                        }
                                        //order1.TotalPrice = itemPrice;
                                   
                                      
                                    }
                                    // else
                                    // {
                                    //     System.Console.WriteLine("Tempropley Unavailable..");
                                    // }
                                    //}


                                    // break;

                                }
                                if(temp2)
                                {
                                    System.Console.WriteLine("Tempropley Unavailable..");
                                }
                                
                                

                            }



                        }
                        if (temp)
                        {
                            System.Console.WriteLine("Invalid item iD..");
                        }
                        

                    }




                }
                if (flag)
                {
                    System.Console.WriteLine("Incorreect OrderID:");
                }




            }

        }


        public static void CancelOrder()
        {
            // 1.	Show the Order details of the current user who’s Order status is “Ordered”.
            foreach (OrderDetails order in orderList)
            {
                if (currentUserLogin.UserID == order.UserID && order.OrderStatus == OrderStatus.Ordered)
                {
                    System.Console.WriteLine($"{order.OrderID}  |  {order.UserID}  |  {order.OrderDate.ToString("dd/MM/yyyy")} | {order.OrderStatus}");
                }
            }
            // 2.	Ask the user to pick an OrderID to cancel.
            System.Console.WriteLine("Enter your Order ID to Cancel order:");
            string orderID = Console.ReadLine();

            // 3.	Check the OrderID is valid. 
            bool flag = true;
            foreach (OrderDetails order1 in orderList)
            {

                // 4.	If valid, then Return the Order total amount to current user.
                if (orderID == order1.OrderID && order1.OrderStatus == OrderStatus.Ordered)
                {
                    flag = false;

                    currentUserLogin.WalletRecharge(order1.TotalPrice);
                    // 5.	Return product orderQuantity to Foodtem list’s FoodQuantity. 
                    foreach (CartItem cart in cartList)
                    {
                        if (cart.OrderID == order1.OrderID)
                        {

                            foreach (FoodDetails food in foodList)
                            {
                                if (food.FoodID == cart.FoodID)
                                {
                                    food.AvailabilityCount = food.AvailabilityCount + cart.OrderQuantity;
                                    break;
                                }

                            }
                        }
                    }

                    // 6.	Change the OrderStatus as Cancelled.
                    order1.OrderStatus = OrderStatus.Cancelled;
                    // 7.	Show “Order cancelled successfully” and //product returned to cart.
                    System.Console.WriteLine("Order Cancelled Sucessfully..");

                }
            }
            //}
            //If not, then show “Invalid OrderID”.
            if (flag)
            {
                System.Console.WriteLine("Invalid Order ID");
            }

        }
        public static void OrderHistory()
        {
            //Show the Order details which placed by the current user.
            foreach (OrderDetails order in orderList)
            {
                if (currentUserLogin.UserID == order.UserID)
                {
                    System.Console.WriteLine($"{order.OrderID}  |  {order.UserID}  |  {order.OrderDate.ToString("dd/MM/yyyy")} | {order.OrderStatus}");
                }
            }
        }
        public static void RechargeWallet()
        {
            //Ask the user whether he want to recharge. 
            // System.Console.WriteLine("Do you want to Recharge");
            // string option=Console.ReadLine();

            // //If yes then, Get the amount to be recharged and
            // if(option=="yes")
            // {
            System.Console.WriteLine("Enter the amouunt for recharge");
            double amount = double.Parse(Console.ReadLine());
            //add the recharged amount to the balance of the user.
            currentUserLogin.WalletRecharge(amount);
            System.Console.WriteLine("Recharge Sucessfully:");
            System.Console.WriteLine("Your wallet balance:" + currentUserLogin.WalletBalance);


            // }

        }
        public static void ShowWalletBalance()
        {
            // Display the user’s wallet balance in console.
            System.Console.WriteLine($"Your Walance balance:{currentUserLogin.WalletBalance}");
        }
    }
}
