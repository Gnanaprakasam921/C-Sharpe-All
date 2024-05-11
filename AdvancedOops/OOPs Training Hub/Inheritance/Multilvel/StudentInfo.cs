using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multilvel
{
    public class StudentInfo:PersionalDetail
    {
         private static int s_regNO=100;
        public string RegNo { get;  }
        public string Std { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }
        
        public StudentInfo(string name,string fatherName, long phone, string mail, DateTime dob, string gender, string std, string branch, int academicYear):base(name, fatherName,phone,mail,dob,gender)
        {
            s_regNO++;
            RegNo="SF"+s_regNO;
            Std=std;
            Branch=branch;
            AcademicYear=academicYear;
        }
             public StudentInfo(string regNo,string name,string fatherName, long phone, string mail, DateTime dob, string gender, string std, string branch, int academicYear):base(name, fatherName,phone,mail,dob,gender)
        {
           
            RegNo=regNo;
           
        }

        public string ShowDetail()
        {
            return($"{RegNo}  |  {Name}  {FatherName}  |  {Mobile}  |  {Mail}  |  {DOB.ToString("dd/MM/yyyy")}  {Gender}  {Std}  |  {Branch}  {AcademicYear} ");
        }


    }
}