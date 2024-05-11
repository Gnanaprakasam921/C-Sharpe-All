using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed3
{
    public class FamilyInfo:PersonlDetail
    {
        //public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int Sibilings { get; set; }
        public string Native { get; set; }

        public FamilyInfo(string fatherName, string motherName, int sibilings, string native)
        {
            FatherName=fatherName;
            MotherName=motherName;
            Sibilings=sibilings;
            Native=native;
        }

        sealed override void Display()
        {
            
        }
    }
}