using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly7
{
    public class Attendence
    {
        public int WrokingDays { get; set; }
        public int Leaves { get; set; }
        public int Permission { get; set; }

        public Attendence(int workingDays, int leaves, int permission)
        {
            WrokingDays=workingDays;
            Leaves=leaves;
            Permission=permission;
        }
        public int Calc()
        {
            //return (WrokingDays-Leaves)*500;
            if(Permission<=3)
            {
               return (WrokingDays-Leaves)*500; 
            }
            return (WrokingDays-(Leaves+1))*500;
        }
    }

}