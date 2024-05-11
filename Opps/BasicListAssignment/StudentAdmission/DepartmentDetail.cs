using System;

namespace StudentAdmission
{
    public enum Department{Select, MCA,EEE,CSE,MECH,ECE,IT}
    public class DepartmentDetail
    {
        private static int s_departmentID=100;
        public string DepartmentID { get; set; }
        public Department Department{ get; set; }
        public int NmberOfSeat  { get; set; }

        public DepartmentDetail(string departmentID, Department department, int numberOfSeats);
        {
            DepartmentID=departmentID;
            Department=department;
        }
    }

}
