using System;
using System.Collections.Generic;
using System.Reflection;

namespace ECommerce
{
    public class Operation
    {
        static List<CustomerDetails> customerList = new List<CustomerDetails>();

        static List<OrderDetails> orderList = new List<OrderDetails>();
        static List<ProductDetails> productList = new List<ProductDetails>();

        static CustomerDetails currentLoginCustomer;
        //rivate static OrderDetails currentOrderDetail;
        public static void AddDefaultData()
        {
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Chennai", 9885858588, 50000, "ravi@mail.com");
            CustomerDetails customer2 = new CustomerDetails("Baskarran", "Chennai", 9885894376, 60000, "baskar@mail.com");
            customerList.Add(customer1);
            customerList.Add(customer2);
            ProductDetails product1 = new ProductDetails("Mobile (Samsung)", 10, 10000, 3);
            ProductDetails product2 = new ProductDetails("Tablet (Lenovo)", 5, 15000, 2);
            ProductDetails product3 = new ProductDetails("Camera (Sony)", 3, 20000, 4);
            ProductDetails product4 = new ProductDetails("I Phone", 5, 50000, 6);
            ProductDetails product5 = new ProductDetails("Laptop (Lenova I3)", 3, 40000, 3);
            ProductDetails product6 = new ProductDetails("headPhone (Boat)", 5, 1000, 2);
            ProductDetails product7 = new ProductDetails("Speakers (Boat)", 4, 500, 2);
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            productList.Add(product7);

            OrderDetails order1 = new OrderDetails("CID3001", "PID2001", 20000, DateTime.Now, 2, OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("CID3002", "PID2002", 40000, DateTime.Now, 2, OrderStatus.Ordered);
            orderList.Add(order1);
            orderList.Add(order2);


            foreach (CustomerDetails customer in customerList)
            {
                Console.WriteLine($"|{customer.CustomerID,-10}  |  {customer.CustomerName,-17}  |  {customer.City}  |  {customer.Mobile,-15}  |   {customer.WalletBalance,-15}    |  {customer.Email,-10}");
            }
            foreach (ProductDetails product in productList)
            {
                Console.WriteLine($"|{product.ProductID,-10}  |  {product.ProductName,-15}  |  {product.Stock,-15}  |   {product.Price,-15}  |   {product.ShipingDuration,-10}");
            }

            foreach (OrderDetails order in orderList)

            {
                Console.WriteLine($"|{order.OrderID,-10}  |  {order.CustomerID,-10}  |  {order.ProductID,-10}  |   {order.TotalPrice,-10}  |  {order.Date.ToString(),-10}  |  {order.OrderStatus,-15}");
            }





        }

        public static void MainMenu()
        {
            bool flag = true;
            //string option="";
            do
            {
                System.Console.Write("ECommerce Application");
                System.Console.WriteLine("1.Registration\n2.Login\n 3.Exit");
                int mainMenu = int.Parse(Console.ReadLine());
                switch (mainMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("Registration Selected");
                            Registration();




                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("login Selected");
                            Operation.Login();
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

        public static void Registration()
        {
            System.Console.WriteLine("Customer Registration:");
            System.Console.Write("Enter Customer Name:");
            string customerName = Console.ReadLine();
            System.Console.Write("Enter Your city:");
            string city = Console.ReadLine();
            System.Console.WriteLine("Enter your Phone:");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.Write("Enter Your mail:");
            string mail = Console.ReadLine();
            CustomerDetails customer = new CustomerDetails(customerName, city, mobile, 0, mail);
            Console.WriteLine(" Register Sucess fully and  Id is" + customer.CustomerID);
            customerList.Add(customer);
            Console.WriteLine("Do you want Continute:");
            string option = Console.ReadLine();

        }
        public static void Login()
        {
            Console.WriteLine("Enter your customer Id");
            string userID = Console.ReadLine().ToUpper();
            int flag = 1;
            foreach (CustomerDetails customer in customerList)
            {
                if (userID == customer.CustomerID)
                {
                    flag = 0;
                    Console.WriteLine("Login Sucess Full");
                    currentLoginCustomer = customer;
                    SubMenu();
                    break;

                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Invalid User Id");
            }

        }

        public static void SubMenu()
        {
            bool flag = true;
            Console.WriteLine("This is SubMenu");
            do
            {

                System.Console.WriteLine("a.Purchese \nb.Order Histry \n c.cancel Order \n d.WalletBalance \n e. Wallet Recharge  \n f.Exit");
                char SubMenu = char.Parse(Console.ReadLine());
                switch (SubMenu)
                {
                    case 'a':
                        {
                            Console.WriteLine("Purches");
                            Purchase();
                            //currentLoginStudent.Average()
                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine("OrderHistry:");
                            OrderHistry();

                            break;
                        }
                    case 'c':
                        {
                            System.Console.WriteLine("Cancel Order: ");
                            CancelOrder();
                            break;
                        }
                    case 'd':
                        {
                            System.Console.WriteLine("Wallebalance:");
                            WalletBalance();
                            break;
                        }
                    case 'e':
                        {
                            System.Console.WriteLine("WalletRecharge");
                            WalletRecharge();
                            break;
                        }
                    case 'f':
                        {
                            Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }

                }
            } while (flag);
        }
        public static void Purchase()
        {
            // 1.	Once the Customer logged in show the list of Products.
            //Login();
            foreach (ProductDetails product in productList)
            {
                Console.WriteLine($"|{product.ProductID,-10}  |  {product.ProductName,-15}  |  {product.Stock,-15}  |   {product.Price,-15}  |   {product.ShipingDuration,-10}");
            }
            //  Ask the customer to select a Product using Product ID. 

            System.Console.WriteLine("Enter product id");
            string productId = Console.ReadLine();
            bool flag = true;
            //bool checkBalance = true;
            //int Purchescount=0;
            foreach (ProductDetails product in productList)
            {
                if (productId == product.ProductID)
                {
                    flag = false;
                    // 3.	If it is valid, Then ask for the count he wish to purchase.
                    Console.WriteLine("Enter your Pruches count");
                    int purchaseCount = int.Parse(Console.ReadLine());
                    if (purchaseCount <= product.Stock)
                    {
                        // 5.	If the count is available calculate total amount with the below formula.

                        // Delivery charge is Rs 50
                        // Total Amount = (required count * price per quantity) + Delivery charge

                        int totalAmount = (purchaseCount * product.Price) + 50;

                        // 6.	Check the current logged in customer’s wallet balance to ensure he is having enough balance to purchase by comparing with total price.

                        if (currentLoginCustomer.WalletBalance >= totalAmount)
                        {
                            //checkBalance = false;
                            // 8.	If the wallet has sufficient balance, then 
                            // a.	Deduct the total amount from the wallet balance of the current logged in customer.
                            currentLoginCustomer.WalletBalance -= totalAmount;
                            // b.	Deduct the count from the stock availability of the product.
                            product.Stock = product.Stock - purchaseCount;
                            // 9.	Create order with available details and make its status as Ordered,
                            OrderDetails newOrder = new OrderDetails(currentLoginCustomer.CustomerID, product.ProductID, totalAmount, DateTime.Now, purchaseCount, OrderStatus.Ordered);
                            orderList.Add(newOrder);
                           

                                    Console.WriteLine($"Order Placed Successfully. Order ID:{newOrder.OrderID} ");
                                    DateTime shipingdate = DateTime.Now.AddDays(product.ShipingDuration);
                                    Console.WriteLine($"Product Delevery date :{shipingdate}");
                         


                            //orderList.Add(currentOrderDetail);
                            // Add it to order List and show “Order Placed Successfully. Order ID: OID1001”.

                            // 10.	Show the delivery date of order by making a calculation based on purchase date and shipping duration of the product like “Order placed successfully. Your order will be delivered on {Order date +shipping duration of the product}.
                            //int deliveryDate=currentOrderDetail.Date+product.ShipingDuration;


                        }
                        else
                        {


                            System.Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet and do purchase again");

                        }

                    }
                    // 4.	If the required count is not available in the product’s stock, then show like “Required count not available. Current availability is {product’s stock count}”.
                    else
                    {
                        Console.WriteLine($"Required count not available. Current availability is :{product.Stock}");
                    }

                }
            }
            // 2.	Validate productID if it is invalid show “Invalid ProductID”. 
            if (flag)
            {
                Console.WriteLine("Invalid Product ID");
            }
            //If the wallet balance is insufficient for this order, then display “Insufficient Wallet Balance. Please recharge your wallet and do purchase again”.
        }
        public static void OrderHistry()
        {
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginCustomer.CustomerID == order.CustomerID)
                {
                    flag = false;
                    Console.WriteLine($"{order.OrderID}  |  {order.CustomerID}  |  {order.ProductID}  |  {order.TotalPrice}  |  {order.Date}  |  {order.Quantiity}  |  {order.OrderStatus}");
                }
            }
            if (flag)
            {
                Console.WriteLine("No any order");
            }

        }
        public static void CancelOrder()
        {
            //bool flag = true;
            // 1.	Show all orders placed by current logged in customer whose order status is Ordered.
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginCustomer.CustomerID == order.OrderID && order.OrderStatus == OrderStatus.Ordered)
                {
                    //flag = false;
                    Console.WriteLine($"{order.CustomerID}  |  {order.CustomerID}  |  {order.ProductID}  |  {order.TotalPrice}  |  {order.Quantiity}  |  {order.OrderStatus}");
                }


            }

            // 2.	Ask customer to select an order to be cancelled by the OrderID.
            Console.WriteLine("Do you want to Order to be cancelled yes or no:");
            string say = Console.ReadLine();
            System.Console.WriteLine("Enter your orderId");
            string orderID = Console.ReadLine();
            bool flag = true;

            foreach (OrderDetails order in orderList)
            {
                if (currentLoginCustomer.CustomerID == order.CustomerID && order.OrderStatus == OrderStatus.Ordered)
                {
                    flag = false;
                   
                    // 3.	Validate orderID and 
                    // 4.	If it is valid then Pick the order based on the provided OrderID.

                    if (order.OrderID == orderID)
                    {
                        foreach (ProductDetails product in productList)
                        {
                            //  5.	Increase the available stock quantity by the count of product purchased in the current order to be cancelled.
                            if (product.ProductID == order.ProductID)
                            {
                                product.Stock += order.Quantiity;
                                // 6.	Refund the amount to the customer’s wallet balance.
                                currentLoginCustomer.WalletBalance += order.TotalPrice;
                                 // 7.	Change the order status to “Cancelled” and finally show “Order :{OrderID} cancelled successfully”
                                 order.OrderStatus = OrderStatus.Cancelled;
                                 //break;

                            }
                        }
                       
                    }

                    System.Console.WriteLine($"Order Canceled{order.OrderID} Sucess fully:");

                }
            }
            if (flag)
            {
                System.Console.WriteLine("Invalid Order Id:");
            }


        }
        public static void WalletBalance()
        {
            Console.WriteLine($"Your Balance:{currentLoginCustomer.WalletBalance}");

        }

        public static void WalleRecharge()
        {
            //             1.	Ask the customer whether he wish to recharge the wallet. 

            //bool flag=true;


            Console.WriteLine("Do you want to Rechagre to the Wallet Yes Or No");
            string option = Console.ReadLine();


            // 2.	If “Yes” then ask for the amount to be recharged and update the amount in the wallet and display the updated wallet balance.
            if (option == "Yes")
            {
                Console.Write("Enter your deposite amount:");
                int amount = int.Parse(Console.ReadLine());
                currentLoginCustomer.WalletRecharege(amount);
                System.Console.WriteLine(currentLoginCustomer.WalletBalance);
                // 3.	Else go the submenu.
            }
            // }while(flag);




        }

    }
}