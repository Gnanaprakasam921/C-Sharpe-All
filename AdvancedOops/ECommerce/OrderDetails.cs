using System;

namespace ECommerce
{
    public enum OrderStatus{Default, Ordered, Cancelled}
    public class OrderDetails
    {
        private static int s_orderID=1000;
        public string OrderID { get;  }
        public string CustomerID { get; set; }
        public string ProductID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public int Quantiity { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(string customerID, string productID, int totalPrice, DateTime date, int quantity, OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            CustomerID=customerID;
            ProductID=productID;
            TotalPrice=totalPrice;
            Date=date;
            Quantiity=quantity;
            OrderStatus=orderStatus;
        }


         public OrderDetails(string order)
        {
            string[] value=order.Split(",");
            OrderID=value[0];
            s_orderID=int.Parse(value[0].Remove(0,3));
            CustomerID=value[1];
            ProductID=value[2];
            TotalPrice=int.Parse(value[3]);
            Date=DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
            Quantiity=int.Parse(value[5]);
            OrderStatus=Enum.Parse<OrderStatus>(value[5]);
        }


        
    }
}
