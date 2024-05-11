using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial1
{
    public partial class EmpInfo
    {
        public void Update()
        {

        }

        public string Dispaly()
        {
            return($"{EmpID}  {Name}  {Gender}  {DOB}  {Mobile}");
        }
    }
}