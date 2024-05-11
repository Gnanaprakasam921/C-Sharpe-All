using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract3
{
    public class MaruthiSwift : Car
    {
          public MaruthiSwift(string enginetype, int seats, double price, string carType)
        {
            EngineType=enginetype;
            Seats=seats;
            Price=price;
            CarType=carType;
        }
        public override string DispalyCarDetails()
        {
           return ($"{EngineType}  {Seats}  {Price}  {CarType}");
        }

        public override string GetCarType()
        {
            return CarType;
        }

        public override string GetEngineType()
        {
           return EngineType;
        }

        public override double GetPrice()
        {
           return Price;
        }

        public override int GetSeat()
        {
            return Seats;
        }
    }
}