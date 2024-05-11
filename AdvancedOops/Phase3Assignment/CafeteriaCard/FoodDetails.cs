using System;

namespace CafeteriaCard
{
    public class FoodDetails
    {
        private static int s_foodID=100;
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int AvailabilityCount { get; set; }

        public FoodDetails(string foodname, double foodPrice, int availabilityCount)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodname;
            FoodPrice=foodPrice;
            AvailabilityCount=availabilityCount;

        }

         public FoodDetails(string food)
        {
            string[] value=food.Split(",");
            
            FoodID=value[0];
            s_foodID=int.Parse(value[0].Remove(0,3));
            FoodName=value[1];
            FoodPrice=double.Parse(value[2]);
            AvailabilityCount=int.Parse(value[3]);

        }
    }
}
