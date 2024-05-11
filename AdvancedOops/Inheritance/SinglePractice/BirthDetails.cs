using System;

namespace SinglePractice
{
    public class BirthDetails
    {
     private static int s_birthID=1000;
       public string BirthID { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }

        public BirthDetails(string name, string fatherName, DateTime dob )
        {
            s_birthID++;
            BirthID="SF"+BirthID;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
        }
        
        public BirthDetails(string birthID,string name, string fatherName, DateTime dob )
        {
            //s_birthID++;
            BirthID=birthID;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
        }
        
        
        
    }
}
