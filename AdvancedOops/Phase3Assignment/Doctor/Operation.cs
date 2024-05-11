using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Doctor
{
    public class Operation
    {
        static List<DoctorDetails> doctorList = new List<DoctorDetails>();
        static List<PatientDetails> patientList = new List<PatientDetails>();
        static List<AppointmentDetails> appointmentList = new List<AppointmentDetails>();
        static PatientDetails currentLoginUser;

        public static void AddDefaultData()
        {

            DoctorDetails doctor1 = new DoctorDetails("Nancy", "Anaesthesiology");
            DoctorDetails doctor2 = new DoctorDetails("Andrew", "Cardiology");
            DoctorDetails doctor3 = new DoctorDetails("Janet", "Diabetology");
            DoctorDetails doctor4 = new DoctorDetails("Margaret", "Neonatology");
            DoctorDetails doctor5 = new DoctorDetails("Steven", "Nephrology");
            doctorList.Add(doctor1);
            doctorList.Add(doctor2);
            doctorList.Add(doctor3);
            doctorList.Add(doctor4);
            doctorList.Add(doctor5);
            foreach (DoctorDetails doctor in doctorList)
            {
                System.Console.WriteLine($"{doctor.DoctorID}    {doctor.Name}     {doctor.Department}");
            }

            PatientDetails patient1 = new PatientDetails("welcome", "Robert", 40, Gender.Male);
            PatientDetails patient2 = new PatientDetails("welcome", "Laura", 36, Gender.Female);
            PatientDetails patient3 = new PatientDetails("welcome", "Anne", 42, Gender.Female);
            patientList.Add(patient1);
            patientList.Add(patient2);
            patientList.Add(patient3);
            foreach (PatientDetails patient in patientList)
            {
                System.Console.WriteLine($"{patient.PatientID} {patient.Name} {patient.Password}  {patient.Age}   {patient.Gender}  ");

            }

            AppointmentDetails appointment1 = new AppointmentDetails("PID2001", "SF1001", new DateTime(2012, 8, 3), "Heart problem");
            AppointmentDetails appointment2 = new AppointmentDetails("PID2001", "SF1005", new DateTime(2012, 8, 3), "Spinal cord injury");
            AppointmentDetails appointment3 = new AppointmentDetails("PID2002", "SF1002", new DateTime(2012, 8, 3), "Heart attack");
            appointmentList.Add(appointment1);
            appointmentList.Add(appointment2);
            appointmentList.Add(appointment3);
            foreach (AppointmentDetails appointment in appointmentList)
            {
                System.Console.WriteLine($"{appointment.AppointmentID}  {appointment.PatientID}   {appointment.DoctorID}   {appointment.Date.ToString("MM/dd/yyyy")}    {appointment.Problem}");
            }
        }

        public static void MainMenu()
        {


            bool flag = true;
            //string option="";
            do
            {
                System.Console.Write("Select Option:");
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
            System.Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            System.Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            PatientDetails patient = new PatientDetails(password, name, age, gender);
            patientList.Add(patient);
            System.Console.WriteLine("RegisterSucessFully: Your ID is" + patient.PatientID);

        }

        public static void Login()
        {
            System.Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();


            int flag = 1;
            foreach (PatientDetails patient in patientList)
            {
                if (name == patient.Name && password == patient.Password)
                {
                    flag = 0;
                    Console.WriteLine("Login Sucess Full");
                    currentLoginUser = patient;
                    SubMenu();
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

                System.Console.WriteLine("1.BookAppointment  2.ViewAppplointmentDetails  3.EditMyProfile    4.Exit");
                int SubMenu = int.Parse(Console.ReadLine());
                switch (SubMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("BookAppointment");
                            BookAppointment();
                            //currentLoginStudent.Average()
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("ViewAppplointmentDetails:");
                            ViewAppplointmentDetails();

                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("EditMyProfile: ");
                            EditMyProfile();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }

                }
            } while (flag);
        }

        public static void BookAppointment()
        {
            //Display the Department list
            foreach (DoctorDetails doctor in doctorList)
            {
                System.Console.WriteLine(doctor.Department);
            }

            System.Console.WriteLine("Enter the Department");
            string department = Console.ReadLine();
            System.Console.WriteLine("Your Problem");
            string problem = Console.ReadLine();
            bool temp = true;
            foreach (DoctorDetails doctor1 in doctorList)
            {

                if (department == doctor1.Department)
                {
                    temp = false;
                    System.Console.WriteLine("Enter the date for appointment");
                    DateTime appointDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);


                    // bool flag = true;
                    if (appointDate >= DateTime.Today)
                    {
                        int count = 0;

                        foreach (AppointmentDetails appointment in appointmentList)
                        {
                            if (appointDate == appointment.Date && appointment.DoctorID == doctor1.DoctorID)
                            {

                                count++;

                            }
                        }
                        if (count < 2)
                        {
                            System.Console.WriteLine("Appointment is confirmed " + appointDate);
                            System.Console.WriteLine("To Book Plase say yes or no");
                            string say = Console.ReadLine();
                            if (say == "yes")
                            {
                                AppointmentDetails appointment1 = new AppointmentDetails(currentLoginUser.PatientID, doctor1.DoctorID, appointDate, problem);
                                appointmentList.Add(appointment1);
                            }
                            else
                            {
                                System.Console.WriteLine("Exiting from appointment option");
                            }
                        }

                    }


                    else
                    {
                        System.Console.WriteLine("Ivaoid D");
                    }
                }

            }
            if (temp)
            {
                System.Console.WriteLine("Invalid departement");
            }

        }

        public static void ViewAppplointmentDetails()
        {
            foreach (AppointmentDetails appointment in appointmentList)
            {
                if (currentLoginUser.PatientID == appointment.PatientID)
                {


                    System.Console.WriteLine($"{appointment.AppointmentID}  {appointment.PatientID}   {appointment.DoctorID}   {appointment.Date.ToString("MM/dd/yyyy")}    {appointment.Problem}");
                }
            }
        }

        public static void EditMyProfile()
        {
            foreach (PatientDetails patient in patientList)
            {
                if (currentLoginUser.PatientID == patient.PatientID)
                {
                    //bool flag=true;
                    // do
                    // {
                    System.Console.WriteLine("Select option for Edit");
                    System.Console.WriteLine("1.Name    2. Pasword  3.Age   4.Gender");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                System.Console.WriteLine("Edit Your name");
                                NameEdit();
                                break;
                            }
                            
                        case 2:
                        {
                            System.Console.WriteLine("Edit password");
                            PasswordEdit();
                            break;
                        }
                        case 3:
                        {
                            System.Console.WriteLine("Edit Age");
                            AgeEdit();
                            break;
                        }
                        case 4:
                        {
                            System.Console.WriteLine("Gender Edit");
                            GenderEdit();
                            break;
                        }
                    }
                   
                }
            }

        }

        public static void NameEdit()
        {
            System.Console.WriteLine("Enter Your new Name");
            string newName=Console.ReadLine();
            currentLoginUser.Name=newName;
            System.Console.WriteLine("Name Changed SucessFully");

        }

        public static void PasswordEdit()
        {
            System.Console.WriteLine("Enter Your New password");
            string newPassword=Console.ReadLine();
            currentLoginUser.Password=newPassword;
            System.Console.WriteLine("Password Changed SucessFully");
        }

        public static void AgeEdit()
        {
            System.Console.WriteLine("Enter Your age");
            int newAge=int.Parse(Console.ReadLine());
            currentLoginUser.Age=newAge;
            System.Console.WriteLine("Age Changed SucessFully");

        }
        public static void GenderEdit()
        {
            System.Console.WriteLine("Change your Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());
            currentLoginUser.Gender=gender;
            System.Console.WriteLine("Gender Changed SucessFully");

        }
    }

}
