using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multilvel
{
    public class HSCDetails: StudentInfo
    {
        private static int s_markSheetNo=1000;
        public string MarksheetNO { get; }
        public int Phy { get; set; }
        public int Che { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }

       // public int MyProperty { get; set; }

        public HSCDetails(string name,string fatherName, long phone, string mail, DateTime dob, string gender, string std, string branch, int academicYear,int phy,int che, int maths):base(name, fatherName,phone,mail,dob,gender,std,branch,academicYear)
        {
            s_markSheetNo++;
            MarksheetNO="SF"+s_markSheetNo;
            Phy=phy;
            Che=che;
            Maths=maths;
           //Total=total;
           // Percentage=percentage;

        }

        //  public HSCDetails(string markSheetNo,string name,string fatherName, long phone, string mail, DateTime dob, string gender, string std, string branch, int academicYear,int phy,int che, int maths, int total, int percentage):base(name, fatherName,phone,mail,dob,gender,std,branch,academicYear)
        // {
           
        //     MarksheetNO=markSheetNo;
           

        // }
        public void GetMark()
        {
            Phy=int.Parse(Console.ReadLine());
            Che=int.Parse(Console.ReadLine());
            Maths=int.Parse(Console.ReadLine());
        }


        public void Calculate()
        {
            Total=Phy+Che+Maths;
            Percentage=Total/3;
            
        }

        public string ShowMarkSheet()
        {
            return($"{MarksheetNO} |  {RegNo}  |  {Name}  {FatherName}  |  {Mobile}  |  {Mail}  |  {DOB.ToString("dd/MM/yyyy")}  {Gender}  {Std}  |  {Branch}  {AcademicYear}  {Phy}  {Che}  {Maths}  {Total}  {Percentage} ");
        }
       

    }
}