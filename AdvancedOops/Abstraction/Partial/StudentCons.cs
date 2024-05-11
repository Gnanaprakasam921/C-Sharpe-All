using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial
{
    public partial class StudentDetails
    {
        public StudentDetails(string name)
        {
            s_studentID++;
            StudentID="SF"+s_studentID;
            Name=name;
        }
    }
}