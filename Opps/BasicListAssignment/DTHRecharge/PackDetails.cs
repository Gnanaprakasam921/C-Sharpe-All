using System;

namespace DTHRecharge
{
    public class PackDetails
    {
        public string PackID { get; set; }
        public string  PackName { get; set; }
        public double Price { get; set; }
        public int Validity { get; set; }
        public int NoOfChennal { get; set; }
        public PackDetails(string packID,string packName, double price, int validity, int noOfChennal)
        {
          PackID=packID;
          PackName=packName; 
          Price=price;
          Validity=validity;
          NoOfChennal=noOfChennal; 

        }

        
    }
}
