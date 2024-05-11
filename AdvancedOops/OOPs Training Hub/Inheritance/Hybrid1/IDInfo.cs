using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Multiple;

namespace Hybrid1
{
    public class IDInfo : PersonalDetails

    {
        public string VoterID { get; set; }
        public string Aadhar { get; set; }
        public string Pan { get; set; }
        public IDInfo(string name, string gender, DateTime dob, long mobile,string voiter, string aadhar, string pan) : base(name, gender, dob, mobile)
        {
            VoterID=voiter;
            Aadhar=aadhar;
            Pan=pan;
        }
    }
}