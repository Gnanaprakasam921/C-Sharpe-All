using System;

namespace MedicalStore
{
    public class MedicineDetails
    {
// a.	MedicineID (Auto increment – MD2000)
// b.	MedicineName
// c.	AvailableCount
// d.	Price
// e.	DateOfExpiry

        private static int s_medicineID;
        public string MedicineID { get;  }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails(string medicineName, int availableCount, double price, DateTime dateOfExiry)
        {
            s_medicineID++;
            MedicineID="MD"+s_medicineID;
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateOfExpiry=dateOfExiry;
        }
        

    }
}
