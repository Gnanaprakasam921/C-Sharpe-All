using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Single
{
    
    public class ClassDetails:PersionalDetail

    
    {
        private static int s_regNO=100;
        public string RegNo { get;  }
        public string Std { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }
        
        public ClassDetails(string name,string fatherName, long phone, string mail, DateTime dob, string gender, string std, string branch, int academicYear):base(name, fatherName,phone,mail,dob,gender)
        {
            s_regNO++;
            RegNo="SF"+s_regNO;
            Std=std;
            Branch=branch;
            AcademicYear=academicYear;
        }
        //   public ClassDetails(string regNo,string name,string fatherName, long phone, string mail, DateTime dob, string gender, string std, string branch, int academicYear):base(name, fatherName,phone,mail,dob,gender)
        // {
           
        //     RegNo=regNo;
           
        // }


        public  string ShowDetailInfo()
        {
          //return ("gnanam,Sekar,987654,Gnanam@gmail.com,28/07/2001,male,MCA, Application,4")
            //ClassDetails classDetails=new ClassDetails("gnanam","Sekar",987654,"Gnanam@gmail.com",new DateTime(28/07/2001),"male","MCA", "Application",4);
            //ClassDetails classDetails1=new ClassDetails("gnanam","Sekar",987654,"Gnanam@gmail.com",new DateTime(28/07/2001),"male","MCA", "Application",4);
        return ($"{RegNo} {Name}  {FatherName} {Mobile}  {Mail}  {DOB.ToString("dd/MM/yyyy")} {Gender}  {Std}  {Branch}  {AcademicYear} ");
        }

    }
}