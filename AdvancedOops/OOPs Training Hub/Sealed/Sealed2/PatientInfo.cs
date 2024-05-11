using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed2
{
    sealed class PatientInfo
    {
        private static int s_pID=1000;
        public string PatientID { get;  }
        public string Name { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmitFor { get; set; }

        public PatientInfo(string name, int bedNo, string native, string reason)
        {
            s_pID++;
            PatientID="SF"+s_pID;
            Name=name;
            BedNo=bedNo;
            NativePlace=native;
            AdmitFor=reason;
        }
        sealed void Display()
        {

        }

    }
}