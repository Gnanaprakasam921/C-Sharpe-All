using System;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;

namespace BloodBank
{
    //public enum BloodGorup {Select, A, B,AB};
    
    public class Registration
    {
        private static int s_donerID=1000;
        public string DonerID { get;  }
        public string DonerName { get; set; }
        public long Mobile { get; set; }
        public  BloodGroup BloodGroup { get; set; }
        public int Age { get; set; }
        public DateTime LastDonate { get; set; }
        
        public  Registration(string donerName, long mobile, BloodGroup bloodGroup,int age, DateTime lastDonate)
        {
            s_donerID++;
            DonerID="UID"+s_donerID;
            DonerName=donerName;
            Mobile=mobile;
            BloodGroup=bloodGroup;
            Age=age;
            LastDonate=lastDonate;

        }
    }
}
