using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract4
{
    public class MensWear:Dress
    {
          public override string DressType { get; set; }
        public override string DressName { get; set;  }
        public override double Price { get; set;  }
        public override double TotalPrice { get; set;  }

        public MensWear(string dressType, string dressName, double price)
        {
            DressType=dressType;
            DressName=dressName;
            Price=price;
          //  TotalPrice=totalPrice;

        }

        public override string DisplayInfo()
        {
            return($"{DressType}  {DressName}  {Price}  {Calc()}");
            
        }
        public double Calc()
        {
            double discount=Price*0.3;
            TotalPrice=Price-discount;
            return TotalPrice;
        }
    }
}