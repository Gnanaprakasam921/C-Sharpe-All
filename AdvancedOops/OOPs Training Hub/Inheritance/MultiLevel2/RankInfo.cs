using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel2
{
    public class RankInfo : DeptDetails
    {
        public int RackNo { get; set; }
        public int  ColNo{ get; set; }
        public RankInfo(string deptnName, string degree,int rackno, int colno) : base(deptnName, degree)
        {

            RackNo=rackno;
            ColNo=colno;
        }
    }
}