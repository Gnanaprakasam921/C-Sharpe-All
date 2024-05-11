using System;

namespace eiraricalPractice
{
    public class BirthDetails : PersonalDeatails
    {
     private static int s_birthID=1000;
       public string BirthID { get;  }
      

        public BirthDetails(string name, string fatherName, DateTime dob ):base(name,fatherName,dob)
        {
            s_birthID++;
            BirthID="SF"+BirthID;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
        }
        
        public BirthDetails(string birthID,string name, string fatherName, DateTime dob ):base(name,fatherName,dob)
        {
            //s_birthID++;
            BirthID=birthID;
            // Name=name;
            // FatherName=fatherName;
            // DOB=dob;
        }
        
        
        
    }
}
