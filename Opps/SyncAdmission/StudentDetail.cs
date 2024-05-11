using System;
using System.Security.Cryptography.X509Certificates;

namespace SyncAdmission
{
    public enum Gender{Select, Male,Femal}
    public class StudentDetail
    {
        private static int s_studentID=3000;
        public string  StudentID { get;  }
        public string StudentName { get; set; }
        public string FatherName{ get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender{get; set;}
        public int Physics { get; set; }
        public int Chemistry{ get; set; }
        public int Maths { get; set; }

        public StudentDetail(string studentName, string fatherName, DateTime dob, Gender gender, int physics, int chemistry, int maths)
        {
            s_studentID++;  // increment the id
            StudentID="SF"+s_studentID;
            StudentName=studentName;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
            public bool IsEligible(double cutOff)
            {
                double avg=(Physics+Chemistry+Maths)/3;
                if(cutOff<=avg)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }

    }
}
