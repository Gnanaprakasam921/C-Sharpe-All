using System;

namespace PayRollApplication
{

    public enum Gender { Select, Male, Female }
    public enum WorkLocation{Select,Chennai,USA,Kenya}
    public class PayRoll
    {
        private static int s_EmployeeID = 1000;
        public string EmployeeID { get; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string TeamName { get; set; }
        
        public DateTime DateOfJoining { get; set; }

        public int NumberOfWorkingDay { get; set; }
        public int NumberOfLeaveTaken { get; set; }
        public Gender Gender { get; set; }

        public PayRoll(string employeeName, string role, WorkLocation workLocation,string teamName,DateTime dateOfJoining,int numberOfWorkingDay, int numberOfLeaveTaken,Gender gender)
        {
            s_EmployeeID++;
            EmployeeID = "SF" + s_EmployeeID;
            EmployeeName = employeeName;
            Role= role;
            WorkLocation=workLocation;
            TeamName=teamName;
            DateOfJoining=dateOfJoining;
            NumberOfWorkingDay=numberOfWorkingDay;
            NumberOfLeaveTaken=numberOfLeaveTaken;
            
            Gender = gender;
          
        }


        public int  SalaryCalc(int numberOfWorkingDay, int numberOfLeaveTaken)
        {
             int salary=(numberOfWorkingDay-numberOfLeaveTaken)*500;

                return salary;
        }
        // public void Deposite(double amount)
        // {
        //     if(amount>0)
        //     {
        //         Balance+=amount;
        //     }
        // }

        // public bool Withdrawn(double amount)
        // {
          
        //     if (Balance <= amount)
        //     {
        //        Balance-=amount;
        //        return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }

       // }

    }


}
