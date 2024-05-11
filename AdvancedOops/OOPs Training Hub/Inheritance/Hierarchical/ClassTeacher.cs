using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical
{
    public class ClassTeacher:PersonalDetails
    {
        private static int s_teacherID=1000;
        public string TeacherID { get;  }
        public string Dept { get; set; }
        public string Subject{ get; set; }
        public string Qualification { get; set; }
        public int Experience { get; set; }
        public DateTime Joining { get; set; }

        public ClassTeacher(string name, string fatherName, long mobile, string mail, DateTime dob, string gender,string dept, string subject,string qualification, int experience, DateTime joining):base( name,  fatherName,  mobile,  mail,  dob,  gender)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Dept=dept;
            Subject=subject;
            Qualification=qualification;
            Experience=experience;
            Joining=joining;
            
        }
         public ClassTeacher(string teacherID,string name, string fatherName, long mobile, string mail, DateTime dob, string gender,string dept, string subject,string qualification, int experience, DateTime joining):base( name,  fatherName,  mobile,  mail,  dob,  gender)
        {
            //s_teacherID++;
            TeacherID=teacherID;
            // Dept=dept;
            // Subject=subject;
            // Qualification=qualification;
            // Experience=experience;
            // Joining=joining;
            
        }

         public string ShowTeacherDetails()
        {
            return($"{TeacherID}  {Name}  {FatherName}  {Mobile}  {Mail}  {DOB}  {Gender}  {Dept}   {Subject}  {Qualification}  {Experience}  {Joining}");
        }
    }
}