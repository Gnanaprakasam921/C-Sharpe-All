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


        
    }
}
