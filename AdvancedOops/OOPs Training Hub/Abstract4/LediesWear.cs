using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract4
{
    public class LediesWear : Dress
    {
        public override string DressType { get; set; }
        public override string DressName { get; set;  }
        public override double Price { get; set;  }
        public override double TotalPrice { get; set;  }

        public LediesWear(string dressType, string dressName, double price)
        {
            DressType=dressType;
            DressName=dressName;
            Price=price;
            //TotalPrice=totalPrice;

        }

        public override string DisplayInfo()
        {
            return($"{DressType}  {DressName}  {Price}  {Calc()}");
            
        }
        public double Calc()
        {
            double discount=Price*0.2;
            TotalPrice=Price-discount;
            return TotalPrice;
        }
    }
}