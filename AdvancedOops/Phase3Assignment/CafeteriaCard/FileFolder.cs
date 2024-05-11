using System;
using System.IO;

namespace CafeteriaCard
{
    public class FileFolder
    {
        public static void Create()
        {
            if(!Directory.Exists("CafeteriaCard"))
            {
                System.Console.WriteLine("Folder Created");
                Directory.CreateDirectory("CafeteriaCard");

            }
            if(!File.Exists("CafeteriaCard/CartItem.csv"))
            {
                System.Console.WriteLine("CartItem csv Created..");
                File.Create("CafeteriaCard/CartItem.csv");
            }
            if(!File.Exists("CafeteriaCard/FoodDetails.csv"))
            {
                System.Console.WriteLine("FoodDEatils csv Created..");
                File.Create("CafeteriaCard/FoodDetails.csv");
            }
            if(!File.Exists("CafeteriaCard/OrderDetails.csv"))
            {
                System.Console.WriteLine("OrderDetails csv Created..");
                File.Create("CafeteriaCard/OrderDetails.csv");
            }
            if(!File.Exists("CafeteriaCard/UserDetails.csv"))
            {
                System.Console.WriteLine("UserDetals csv Created..");
                File.Create("CafeteriaCard/UserDetails.csv");
            }
        }
        public static void WriteCsv()
        {
            string[] user=new string[Operation.userList.Count];

            for(int i=0;i<Operation.userList.Count;i++)
            {
                user[i]=Operation.userList[i].UserID+","+Operation.userList[i].Name+","+Operation.userList[i].FatherName+","+Operation.userList[i].Mobile+","+Operation.userList[i].Mail+","+Operation.userList[i].Gender+","+Operation.userList[i].WorkStationNumber+","+Operation.userList[i].WalletBalance;
            }
            File.WriteAllLines("CafeteriaCard/UserDetails.csv",user);

            string[] food=new string[Operation.foodList.Count];

            for(int i=0;i<Operation.foodList.Count;i++)
            {
                food[i]=Operation.foodList[i].FoodID+","+Operation.foodList[i].FoodName+","+Operation.foodList[i].FoodPrice+","+Operation.foodList[i].AvailabilityCount;
            }
            File.WriteAllLines("CafeteriaCard/FoodDetails.csv",food);

             string[] order=new string[Operation.orderList.Count];

            for(int i=0;i<Operation.orderList.Count;i++)
            {
                order[i]=Operation.orderList[i].OrderID+","+Operation.orderList[i].UserID+","+Operation.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operation.orderList[i].TotalPrice+","+Operation.orderList[i].OrderStatus;
            }
            File.WriteAllLines("CafeteriaCard/OrderDetails.csv",order);

             string[] item=new string[Operation.cartList.Count];

            for(int i=0;i<Operation.cartList.Count;i++)
            {
               item[i]=Operation.cartList[i].ItemID+","+Operation.cartList[i].OrderID+","+Operation.cartList[i].FoodID+","+Operation.cartList[i].OrderPrice+","+Operation.cartList[i].OrderQuantity;
            }
            File.WriteAllLines("CafeteriaCard/CartItem.csv",item);

        }
        public static void ReadCsv()
        {
            string[] users=File.ReadAllLines("CafeteriaCard/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails user1=new UserDetails(user);
                Operation.userList.Add(user1);
            }

             string[] foods=File.ReadAllLines("CafeteriaCard/FoodDetails.csv");
            foreach(string food in foods)
            {
                FoodDetails food1=new FoodDetails(food);
                Operation.foodList.Add(food1);
            }
             string[] orders=File.ReadAllLines("CafeteriaCard/OrderDetails.csv");
            foreach(string order in orders)
            {
               OrderDetails order1=new OrderDetails(order);
                Operation.orderList.Add(order1);
            }

             string[] items=File.ReadAllLines("CafeteriaCard/CartItem.csv");
            foreach(string item in items)
            {
                CartItem item1=new CartItem(item);
                Operation.cartList.Add(item1);
            }
        }
    }
}
