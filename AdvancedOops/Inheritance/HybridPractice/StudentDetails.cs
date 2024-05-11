using System;

namespace HybridPractice
{
    public class StudentDetails : AadharDetail, IMarkDetails
    {
        private static int s_studentID=1000;
        public string StudentID { get;  }
        public string  Std { get; set; }

        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }

        public StudentDetails(string aadharID, string birthID, string name, string fatherName, DateTime dob, string address,string std):base(aadharID, birthID, name, fatherName,dob,address)
        {
            s_studentID++;
            StudentID="SF"+s_studentID;
            Std=std;
        }

        public void GetMark(int mark1, int mark2, int mark3)

        {
            Mark1=mark1;
            Mark2=mark2;
            Mark3=mark3;
        }
    }
}
