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
        public DepartmentDetail(string department)
        {
            string[] value=department.Split(",");
            
            DepartmentID=value[0];
            s_departmenID=int.Parse(value[0].Remove(0,3));
            DepartmentName=value[1];
            NumberOfSeat=int.Parse(value[2]);
        }
    }
}
