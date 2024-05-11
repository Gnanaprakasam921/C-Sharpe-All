using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        public double Total()
        {
            return Phy+Che+Maths;
            
        }
        public double  Percent()
        {
            //return Total()/300*100;
            double cent=Total()/300*100;
            return cent;
           
        }

        public string Display()
        {
            return ($"{StudID}  {Name}  {Gender}  {DOB}  {Mobile}  {Phy}  {Che}  {Maths}  {Total()}  {Percent()}");
        }
    }
}