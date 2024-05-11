using System;

namespace ECommerce
{
    public class ProductDetails
    {
        private static int s_productID=2000;
        public string ProductID { get; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public int ShipingDuration { get; set; }

        public ProductDetails(string productName, int stock, int price, int shipingDuration)
        {
            s_productID++;
            ProductID="PID"+s_productID;
            ProductName=productName;
            Stock=stock;
            Price=price;
            ShipingDuration=shipingDuration;
        }
    }
}
