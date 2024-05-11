using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Threading;

namespace SyncAdmission
{
    public static class Operation
    {
        public static List<StudentDetail> studentItem = new List<StudentDetail>();
        public static List<DepartmentDetail> departmentItem = new List<DepartmentDetail>();
        public static List<AdmissionDetail> admissionItem = new List<AdmissionDetail>();
        public static StudentDetail currentLoginStudent;
        public static void AddDefaultData()
        {
            //System.Console.WriteLine("Gnanaprakasam");
            // create list for all classes
            //Create object
            // Add to list
            //Traverse and show added data


            // object for student detail
            StudentDetail student1 = new StudentDetail("Ravichandran E", "Ettapparajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95);
            StudentDetail student2 = new StudentDetail("Baskaran S", "Sethurajan", new DateTime(1998, 10, 15), Gender.Male, 98, 92, 91);
            //add student detail item
            studentItem.Add(student1);
            studentItem.Add(student2);
            // onject create for department detal
            DepartmentDetail department1 = new DepartmentDetail("EEE", 29);
            DepartmentDetail department2 = new DepartmentDetail("CSC", 29);
            DepartmentDetail department3 = new DepartmentDetail("MECH", 30);
            DepartmentDetail department4 = new DepartmentDetail("ECE", 30);
            // add department detail item
            departmentItem.Add(department1);
            departmentItem.Add(department2);
            departmentItem.Add(department3);
            departmentItem.Add(department4);
            // object create for Admission detail item;
            AdmissionDetail admission1 = new AdmissionDetail("SF3001", "DID101", new DateTime(2022 / 05 / 11), AdmissionStatus.Admitted);
            AdmissionDetail admission2 = new AdmissionDetail("SF3002", "DID102", new DateTime(2022 / 05 / 12), AdmissionStatus.Admitted);
            //add Admission detail item
            admissionItem.Add(admission1);
            admissionItem.Add(admission2);

            foreach (StudentDetail students in studentItem)
            {
                System.Console.WriteLine($"| {students.StudentID,-15} | {students.StudentName,-15} | {students.FatherName,-15} | {students.DOB.ToString("dd/MM/yyyy"),-15} | {students.Gender} | {students.Physics,-10} | {students.Chemistry,-10} | {students.Maths,-10}");
            }
            foreach (DepartmentDetail departments in departmentItem)
            {
                System.Console.WriteLine($"{departments.DepartmentID,-10}  |  {departments.DepartmentName,-15}  |  {departments.NumberOfSeat,-10}");
            }
            foreach (AdmissionDetail admissions in admissionItem)
            {
                System.Console.WriteLine($"{admissions.AdmissionID}  |  {admissions.StudentID}  |  {admissions.DepartmentID}  |  {admissions.AdmissionDate.ToString("dd/MM/yyyy")}  |  {admissions.AdmissionStatus}");
            }
        }

        public static void MainMenu()
        {
            bool flag = true;
            //string option="";
            do
            {
                System.Console.Write("Syncfusion College:");
                System.Console.WriteLine("1.Registration\n2.Login\n 3.Exit");
                int mainMenu = int.Parse(Console.ReadLine());
                switch (mainMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("Registration Selected");
                            Registration();

                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("login Selected");
                            Operation.Login();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exit Selected");
                            flag = false;
                            break;
                        }

                }
            } while (flag);
        }
        public static void Registration()
        {
            System.Console.WriteLine("Stuent Registration:");
            System.Console.Write("Enter Student Name:");
            string studentName = Console.ReadLine();
            System.Console.Write("Enter Your Father Name:");
            string fatherName = Console.ReadLine();
            System.Console.Write("Enter Your Date of Birth:");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            System.Console.Write("Enter Your Gender Male or Female:");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.Write("Enter Your Physics Mark:");
            int physics = int.Parse(Console.ReadLine());
            System.Console.Write("Enter Your Chemistry Mark:");
            int chemistry = int.Parse(Console.ReadLine());
            System.Console.Write("Enter Your Maths Mark:");
            int maths = int.Parse(Console.ReadLine());
            StudentDetail student = new StudentDetail(studentName, fatherName, dob, gender, physics, chemistry, maths);
            Console.WriteLine("Student Register Sucess fully and Student Id is" + student.StudentID);
            studentItem.Add(student);
            Console.WriteLine("Do you want Continute:");
            //option

        }
        public static void Login()
        {
            //Get user Id
            //traverse Student List
            // find user Id is present 
            // user if is not present show invalid user id
            // if Id present show current cookie object goblally
            // then show the sub menu.
            Console.WriteLine("Enter User ID");
            string userID = Console.ReadLine().ToUpper();
            int flag = 1;
            foreach (StudentDetail students in studentItem)
            {
                if (userID == students.StudentID)
                {
                    flag = 0;
                    Console.WriteLine("Login Sucess Full");
                    currentLoginStudent = students;
                    Operation.SubMenu();
                    break;

                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Invalid User Id");
            }

        }

        public static void SubMenu()
        {
            bool flag = true;
            Console.WriteLine("This is SubMenu");
            do
            {

                System.Console.WriteLine("1.Check eligbible \n2.Show Detail \n 3.Take Admission \n 4.Cancel Admission \n 5. Show Admission Detail \n 6.Exit");
                int SubMenu = int.Parse(Console.ReadLine());
                switch (SubMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("CheckEligibility");
                            Eligible();
                            //currentLoginStudent.Average()
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Show Deatail:");
                            ShowDetail();

                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Take Admission: ");
                            TakeAdmission();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("Cancel Admission:");
                            CancelAdmission();
                            break;
                        }
                    case 5:
                        {
                            System.Console.WriteLine("Show Admissionn Detail");
                            ShowAdmissionDetail();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }

                }
            } while (flag);
        }


        public static void Eligible()
        {
            bool temp = currentLoginStudent.IsEligible(75);
            if (temp == true)
            {
                Console.WriteLine("Your Eligible for Admission");
            }
            else
            {
                Console.WriteLine("Your Not Eligible");
            }

        }
        public static void ShowDetail()
        {
            Console.WriteLine($"{currentLoginStudent.StudentID}  | {currentLoginStudent.StudentName}  | {currentLoginStudent.FatherName}  |  {currentLoginStudent.DOB}  |  {currentLoginStudent.Gender}  |  {currentLoginStudent.Physics}  |  {currentLoginStudent.Maths}  |  {currentLoginStudent.Chemistry}");
        }

        public static void TakeAdmission()
        {
            //•	Show the list of available departments and number of seats available by traversing the department details list
            foreach (DepartmentDetail departments in departmentItem)
            {
                System.Console.WriteLine($"{departments.DepartmentID,-10}  |  {departments.DepartmentName,-15}  |  {departments.NumberOfSeat,-10}");
            }
            //  Ask the student to pick one DepartmentID.
            Console.WriteLine("Enter Department ID");
            string departmentID = Console.ReadLine();

            //	Validate the DepartmentID is present in the list. 
            bool flag = true;
            foreach (DepartmentDetail department in departmentItem)
            {

                if (departmentID == department.DepartmentID)
                {
                    flag = false;
                    // If it is present, then check whether he is eligible to take admission.
                    bool temp = currentLoginStudent.IsEligible(75);
                    if (temp)
                    {
                        //•If he is eligible, check whether seat available or not.
                        if (department.NumberOfSeat > 0)
                        {
                            // if seats available then Check whether the student has already taken any admission by traversing admission details list. If he didn’t took any admission previously. 
                            bool admissionStatusFlag = true;
                            foreach (AdmissionDetail admission in admissionItem)
                            {

                                if (currentLoginStudent.StudentID == admission.StudentID && admission.AdmissionStatus == AdmissionStatus.Admitted)
                                {
                                    admissionStatusFlag = false;

                                    
                                }

                            }
                            //•	Then, Reduce the seat count in department list and create admission details object by using StudentID, DepartmentID, AdmissionDate as Now, AdmissionStatus and Booked and add it to list.
                            if (admissionStatusFlag)
                            {
                                department.NumberOfSeat--;
                                AdmissionDetail admission = new AdmissionDetail(currentLoginStudent.StudentID, department.DepartmentID, DateTime.Now, AdmissionStatus.Admitted);
                                admissionItem.Add(admission);
                                //•	Finally show “Admission took successfully. Your admission ID – SF3001”.
                                Console.WriteLine($"Admission took successfully. Your admission ID :{admission.AdmissionID}");
                            }
                            else
                            {
                                Console.WriteLine("You have already taken Admission");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("No Seats Avialable:");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Not Eligible");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid Department ID");
            }










        }

        public static void CancelAdmission()
        {
            bool flag = true;
            //      Show the current logged in student’s admission detail by traversing the list which AdmissionStatus Property is Booked. If fount then show it.
            foreach (AdmissionDetail admission in admissionItem)
            {
                if (currentLoginStudent.StudentID == admission.StudentID && admission.AdmissionStatus == AdmissionStatus.Admitted)
                {
                    flag = false;
                    // •	Change the Admission status property to Cancelled
                    admission.AdmissionStatus = AdmissionStatus.Cancelled;
                    // •	Return the seat to Department Details list
                    foreach (DepartmentDetail department in departmentItem)
                    {
                        if (department.DepartmentID == admission.DepartmentID)
                        {
                            department.NumberOfSeat++;
                        }
                    }
                    // •	Finally show admission cancelled successfully.
                    Console.WriteLine("Admission cancelled Sucessfully");
                }
            }
            if (flag)
            {
                Console.WriteLine("You have Not taken any admission:");
            }






        }

        public static void ShowAdmissionDetail()
        {
            int flag = 1;
            foreach (AdmissionDetail admissions in admissionItem)
            {
                if (currentLoginStudent.StudentID == admissions.StudentID)
                {
                    flag = 0;
                    System.Console.WriteLine($"{admissions.AdmissionID}  |  {admissions.StudentID}  |  {admissions.DepartmentID}  |  {admissions.AdmissionDate.ToString("dd/MM/yyyy")}  |  {admissions.AdmissionStatus}");
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("No Admission found:");
            }

        }
    }
}



