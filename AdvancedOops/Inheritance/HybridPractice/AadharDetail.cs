using System;

namespace HybridPractice
{
    public class AadharDetail:BirthDetails
    {
        public static int s_aadharID=2000;
        public string AadharID { get; set; }
        public string Address { get; set; }
        

        public AadharDetail(string birthID,string name, string fatherName, DateTime dob, string address):base(birthID, name, fatherName, dob)
        {
            // s_birthID++;
            // BirthID="SF"+BirthID;
            s_aadharID++;
            AadharID="AD"+s_aadharID;
            //Name=name;
            //FatherName=fatherName;
            //DOB=dob;
            Address=address;
        }

        
        public AadharDetail(string aadharID,string birthID,string name, string fatherName, DateTime dob, string address):base(birthID, name, fatherName, dob)
        {
           
            s_aadharID++;
            AadharID=aadharID;
            
            Address=address;
        }
    }
}
