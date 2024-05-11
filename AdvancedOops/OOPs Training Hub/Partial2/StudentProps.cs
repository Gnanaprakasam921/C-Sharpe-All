using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        private static int s_studID=1000;
        public string StudID { get;  }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }
        public int Phy { get; set; }
        public int Che { get; set; }
        public int Maths { get; set; }

    }
}