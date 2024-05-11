using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hierarchical;

namespace Hybrid
{
    public class TheoryExamMark:PersonalDetails
    {
        public int[] Mark1 { get; set; }
        public int[] Mark2 { get; set; }
        public int[] Mark3 { get; set; }

        public TheoryExamMark(string name, string fatherName, long mobile, string mail, DateTime dob, string gender,int[] mark1, int[] mark2, int[] mark3):base (name, fatherName, mobile, mail,  dob,  gender)
        {
            Mark1=new int[6];
            Mark2=new int[6];
            Mark3=new int[6];

            Mark1=mark1;
            Mark2=mark2;
            Mark3=mark3;

        }
    }
}