using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical
{
    public class StudentInfo:PersonalDetails
    {
        private static int s_studentID=1000;
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Dept { get; set; }
        public int Semester { get; set; }

        public StudentInfo(string name, string fatherName, long mobile, string mail, DateTime dob, string gender,string degree, string dept, int semester):base(name,  fatherName,  mobile,  mail,  dob,  gender)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Degree=degree;
            Dept=dept;
            Semester=semester;
        }
          public StudentInfo(string studentID,string name, string fatherName, long mobile, string mail, DateTime dob, string gender,string degree, string dept, int semester):base(name,  fatherName,  mobile,  mail,  dob,  gender)
        {
           // s_studentID++;
            StudentID=studentID;
            // Degree=degree;
            // Dept=dept;
            // Semester=semester;
        }

        public string ShowStudetDetails()
        {
            return($"{StudentID}  {Name}  {FatherName}  {Mobile}  {Mail}  {DOB}  {Gender}  {Degree}  {Dept}  {Semester}");
        }

    }
}