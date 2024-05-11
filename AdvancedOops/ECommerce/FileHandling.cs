using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ECommerce
{
    public  static class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("ECommerce"))
            {
                System.Console.WriteLine("Create Folder..");
                Directory.CreateDirectory("Ecommerce");
            }
            if(!File.Exists("Ecommerce/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Create csv for Custmer Detail");
                File.Create("Ecommerce/CustomerDetails.csv");

            }
            if(!File.Exists("Ecommerce/OrderDetails.csv"))
            {
                System.Console.WriteLine("Create csv for Order Details..");
                File.Create("Ecommerce/OrderDetails.csv");
            }

            if(!File.Exists("Ecommerce/ProductDetails.csv"))
            {
                System.Console.WriteLine("Create csv for Prodeuct Details");
                File.Create("Ecommerce/ProductDetails.csv");
            }
        }

        public static void WriteCsv()
        {
            string[] customer=new string[Operation.customerList.Count];
            for(int i=0;i<Operation.customerList.Count;i++)
            {
                customer[i]=Operation.customerList[i].CustomerID+","+Operation.customerList[i].CustomerName+","+Operation.customerList[i].City+","+Operation.customerList[i].Mobile+","+Operation.customerList[i].WalletBalance+","+Operation.customerList[i].Email;
            }
            File.WriteAllLines("Ecommerce/CustomerDetails.csv",customer);

            string[] order=new string[Operation.orderList.Count];
            for(int i=0;i<Operation.orderList.Count;i++)
            {
                order[i]=Operation.orderList[i].OrderID+","+Operation.orderList[i].CustomerID+","+Operation.orderList[i].ProductID+","+Operation.orderList[i].TotalPrice+","+Operation.orderList[i].Date.ToString("dd/MM/yyyy")+","+Operation.orderList[i].Quantiity+","+Operation.orderList[i].OrderStatus;
            }
            File.WriteAllLines("Ecommerce/OrderDetails.csv",order);

            string[] product=new string[Operation.productList.Count];
            for(int i=0;i<Operation.productList.Count;i++)
            {
                product[i]=Operation.productList[i].ProductID+","+Operation.productList[i].ProductName+","+Operation.productList[i].Stock+","+Operation.productList[i].Price+","+Operation.productList[i].ShipingDuration;
            
            }
            File.WriteAllLines("Ecommerce/ProductDetails.csv",product);
        }
        public static void ReadCsv()
        {
            string[] customers=File.ReadAllLines("Ecommerce/CustomerDetails.csv");
            foreach(string customer in customers)
            {
                CustomerDetails customer1=new CustomerDetails(customer);
                Operation.customerList.Add(customer1);
            }



            string[] products=File.ReadAllLines("Ecommerce/ProductDetails.csv");
            foreach(string product in products)
            {
                ProductDetails product1=new ProductDetails(product);
                Operation.productList.Add(product1);
            }

            string[] orders=File.ReadAllLines("Ecommerce/OrderDetails.csv");
            foreach(string order in orders)
            {
                OrderDetails order1 =new OrderDetails(order);
                Operation.orderList.Add(order1);
            }
        }
    }
}
