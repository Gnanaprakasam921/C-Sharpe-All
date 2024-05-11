using System;
using System.IO;

namespace SyncAdmission
{
    public static class FileHandlinng
    {
        public static void Create()
        {
            if(!Directory.Exists("SyncAdmission"))
            {
                System.Console.WriteLine("Created...");
                Directory.CreateDirectory("SyncAdmission");
            }

            // file for Student info
            if(!File.Exists("SyncAdmission/StudentDetail.csv"))
            {
                System.Console.WriteLine("Created1...");
                File.Create("SyncAdmission/StudentDetail.csv").Close();
            }
            //fiel for Departemtn
            if(!File.Exists("SyncAdmission/DepartmentDetail.csv"))
            {
                System.Console.WriteLine("Created2");
                File.Create("SyncAdmission/DepartmentDetail.csv").Close();
            }

            //file for Admisssion Detail3
            if(!File.Exists("SyncAdmission/AdmissionDetail.csv"))
            {
                System.Console.WriteLine("Created3");
                File.Create("SyncAdmission/AdmissionDetail.csv").Close();
            }
        }

        public static void WriteToCsv()
        {
            string[] students=new string[Operation.studentItem.Count];
            // student info
            for(int i=0;i<Operation.studentItem.Count;i++)
            {
                students[i]=Operation.studentItem[i].StudentID+","+Operation.studentItem[i].StudentName+","+Operation.studentItem[i].FatherName+","+Operation.studentItem[i].DOB.ToString("dd/MM/yyyy")+","+Operation.studentItem[i].Gender+","+Operation.studentItem[i].Physics+","+Operation.studentItem[i].Chemistry+","+Operation.studentItem[i].Maths;
            }
            File.WriteAllLines("SyncAdmission/StudentDetail.csv",students);

            string[] department=new string[Operation.departmentItem.Count];
            //department info
            for(int i=0;i<Operation.departmentItem.Count;i++)
            {
                department[i]=Operation.departmentItem[i].DepartmentID+","+Operation.departmentItem[i].DepartmentName+","+Operation.departmentItem[i].NumberOfSeat;
            }
            File.WriteAllLines("SyncAdmission/DepartmentDetail.csv",department);

            //Admission Detail

            string[] admission=new string[Operation.admissionItem.Count];
            for(int i=0;i<Operation.admissionItem.Count;i++)
            {
                admission[i]=Operation.admissionItem[i].AdmissionID+","+Operation.admissionItem[i].StudentID+","+Operation.admissionItem[i].DepartmentID+","+Operation.admissionItem[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operation.admissionItem[i].AdmissionStatus;


            }
            File.WriteAllLines("SyncAdmission/AdmissionDetail.csv",admission);
        }

        public static void ReadFormCsv()
        {
            string[] students=File.ReadAllLines("SyncAdmission/StudentDetail.csv");
            foreach(string student in students)
            {
                StudentDetail student1=new StudentDetail( student);
                Operation.studentItem.Add(student1);
            }

            string[] departments=File.ReadAllLines("SyncAdmission/DepartmentDetail.csv");
            foreach(string department in departments)
            {
                DepartmentDetail department1=new DepartmentDetail(department);
                Operation.departmentItem.Add(department1);
            }

             string[] admissions=File.ReadAllLines("SyncAdmission/AdmissionDetail.csv");
            foreach(string admission in admissions)
            {
                AdmissionDetail admission1=new AdmissionDetail(admission);
                Operation.admissionItem.Add(admission1);
            }




       }

        

        


    }
}
