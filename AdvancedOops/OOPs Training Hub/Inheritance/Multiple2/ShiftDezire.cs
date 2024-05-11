using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple2
{
    public class ShiftDezire:Car,IBrand
    {
        private static int s_makingID=1000;

       
        public string MakingID { get; set; }
        public long EngineNumber { get; set; }
        public long ChasisNumber { get; set; }

        
        public string BrandName { get; set; }
        public string Model { get; set; }

         public ShiftDezire(string fuleType, int seat, string color, double capacity, double km, long engineNumber, long chasisNumber,string brandName, string model) : base(fuleType, seat, color, capacity, km)

        {
            s_makingID++;
            MakingID="SF"+s_makingID;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            BrandName=brandName;
            Model=model;
        }

        public string ShowDetails()
        {
            return($"{MakingID}  {FuleType}  {NoOfSeat}  {Color}  {TackCapacity}  {Km}    {EngineNumber}  {ChasisNumber}  {BrandName}  {Model}");
        }
        
    }
}