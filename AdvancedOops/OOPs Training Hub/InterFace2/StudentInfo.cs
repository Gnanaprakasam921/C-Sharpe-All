using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterFace2
{
    public class StudentInfo:IDisplayInfo
    {
        private static int s_studentID=1000;
        public string StudentID { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }

        public StudentInfo(string name,string fatherName, long mobile)
        {
            s_studentID++;
            StudentID="SF"+s_studentID;
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;

        }
        public string Display()
        {
            return($"{StudentID}  {Name}  {FatherName}  {Mobile}");
        }
        
    }
}