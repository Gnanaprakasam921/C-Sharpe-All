using System;
using System.Security.Cryptography.X509Certificates;

namespace SyncAdmission
{
    public enum Gender{Select, Male,Female}
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

          public StudentDetail(string student)
        {
           string[] value=student.Split(",");
            StudentID=value[0];
            s_studentID=int.Parse(value[0].Remove(0,2));
            StudentName=value[1];
            FatherName=value[2];
            DOB=DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
            Gender=Enum.Parse<Gender>(value[4]);
            Physics=int.Parse(value[5]);
            Chemistry=int.Parse(value[6]);
            Maths=int.Parse(value[7]);
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
