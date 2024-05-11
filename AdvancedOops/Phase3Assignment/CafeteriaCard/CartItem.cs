using System;

namespace CafeteriaCard
{
    public class CartItem
    {
        private static int s_itemID=100;
        public string ItemID { get; set; }
        public string OrderID { get; set; }
        public string FoodID { get; set; }
        public double OrderPrice { get; set; }
        public int OrderQuantity { get; set; }

        public CartItem(string orderID, string foodID, double orderPrice, int orderQuantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=orderQuantity;
        }

           public CartItem(string item)
        {
            string[] value=item.Split(",");
            s_itemID=int.Parse(value[0].Remove(0,4));
            ItemID=value[0];
            OrderID=value[1];
            FoodID=value[2];
            OrderPrice=double.Parse(value[3]);
            OrderQuantity=int.Parse(value[4]);
        }
    }
}
