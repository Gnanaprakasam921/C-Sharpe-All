using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hierarchical;

namespace Hybrid
{
    public class MarkSheet:TheoryExamMark,ICalculate

    {
        public string MarksheetNumber{ get; set; }
        public string DateofIssue { get; set; }
        public int Total { get; set; }
        public double Percent { get; set; }
        public int ProjectMark { get;set; }
        int Mark1;
        int Mark2;
        int Mark3;
        public MarkSheet(string name, string fatherName, long mobile, string mail, DateTime dob, string gender,int[] mark1, int[] mark2, int[] mark3,string markssheetNumber, string dateOfissue, int total, double percent): base( name,  fatherName,  mobile,  mail,  dob,  gender, mark1, mark2, mark3)
        {
            MarksheetNumber=markssheetNumber;
            DateofIssue=dateOfissue;
            Mark1=mark1[0]+mark1[1]+mark1[2]+mark1[3]+mark1[4]+mark1[5];
            Mark2=mark2[0]+mark2[1]+mark2[2]+mark2[3]+mark2[4]+mark2[5];
            Mark3=mark3[0]+mark3[1]+mark3[2]+mark3[3]+mark3[4]+mark3[5];
        }
        

        public void CalculateUG(int total, double percent)
        {
            Total=Mark1+Mark2+Mark3;
            Percent=Total/3;
        }

        public string Showdetails()
        {
            return($"{Name}  {FatherName}  {Mobile}  {DOB}  {Gender}  {Mark1}  {Mark2}  {Mark3}  {Total}  {Percent}  {MarksheetNumber}  {DateofIssue}");
        }
        
    }
}