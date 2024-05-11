using System;
using System.Text.RegularExpressions;

namespace StudentAdmission
{
    public enum Gender { Select, Male, Female, Transgender}

    public class StudentRegister
    {
        private static int s_studentID=3000;
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }

        public StudentRegister(string studentName,string fatherName, Gender gender, DateTime dob, double physics,double chemistry, double maths)
        {
            //StudentID=studentID;
            StudentName=studentName;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public bool Eligibility()
        {
         
         if(((Physics+Chemistry+Maths)/3)>=75)
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
