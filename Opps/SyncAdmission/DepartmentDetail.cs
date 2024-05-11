using System;

namespace SyncAdmission
{
    public class DepartmentDetail
    {
        private static int s_departmenID=100;
        public string DepartmentID { get;  }
        public string DepartmentName { get; set; }
        public int NumberOfSeat { get; set; }

        public DepartmentDetail(string departmentName, int numberOfSeat)
        {
            s_departmenID++;
            DepartmentID="DID"+s_departmenID;

            DepartmentName=departmentName;
            NumberOfSeat=numberOfSeat;
        }
    }
}
