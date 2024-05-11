using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple2
{
    public class Car
    {
        public string FuleType { get; set; }
        public int NoOfSeat { get; set; }
        public string Color { get; set; }
        public double TackCapacity { get; set; }
        public double Km { get; set; }

        public Car(string fuleType, int seat, string color, double capacity, double km)
        {
            FuleType=fuleType;
            NoOfSeat=seat;
            Color=color;
            TackCapacity=capacity;
            Km=km;

        }

        public void CalMilage()
        {

        }
    }
}