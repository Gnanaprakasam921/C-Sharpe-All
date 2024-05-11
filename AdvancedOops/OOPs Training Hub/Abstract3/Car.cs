using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract3
{
    public abstract class Car
    {
        private int _wheels=4;
        private int _door=4;
        public string EngineType { get; set; }
        public int Seats { get; set; }
        public double Price { get; set; }
        public string CarType { get; set; }

        // public Car(string enginetype, int seats, double price, string carType)
        // {
        //     EngineType=enginetype;
        //     Seats=seats;
        //     Price=price;
        //     CarType=carType;
        // }
        public  int ShowWeels()
        {
            return _wheels;
        }
        public int Door()
        {
            return _door;
        }

        public abstract string GetEngineType();
        public abstract int GetSeat();
        public abstract double GetPrice();
        public abstract string GetCarType();
        public abstract string DispalyCarDetails();

    }
}