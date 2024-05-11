using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Marksheet : IMarkDetails
    {
        // only prop and method  declartion allwed

        // by default access modifier is public

        int Mark1{get;set;}
        int Mark2{get;set;}
        int Mark3{get;set;}

        public Marksheet(int mark1, int mark2, int mark3)
        {
            Mark1=mark1;
            Mark2=mark2;
            Mark3=mark3;
        }
        void GetMarks(int mark1, int mark2, int mark3)
        {
            Mark1=mark1;
            Mark2=mark2;
            Mark3=mark3;
        }
    }
}
