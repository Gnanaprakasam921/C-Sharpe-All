using System;
using System.Collections.Generic;

namespace VaccinationDrive
{

    public class Operation
    {
        static List<BeneficiaryDetails> beneficiarieList = new List<BeneficiaryDetails>();
        static List<VaccineDetails> vaccineList = new List<VaccineDetails>();
        static List<VaccinationDetails> vaccinationList = new List<VaccinationDetails>();
        static BeneficiaryDetails currentLoginUser;

        public static void AddDefaultData()
        {
            // BID1001	"Ravichandran",	21,Gender.Male,	8484484,"Chennai"
            // BID1002	"Baskaran",22,Gender.Male,	8484747,"Chennai"
            BeneficiaryDetails beneficiary1 = new BeneficiaryDetails("Ravichandran", 21, Gender.Male, 8484484, "Chennai");
            BeneficiaryDetails beneficiary2 = new BeneficiaryDetails("Baskaran", 22, Gender.Male, 8484747, "Chennai");
            beneficiarieList.Add(beneficiary1);
            beneficiarieList.Add(beneficiary2);
            foreach (BeneficiaryDetails beneficiary in beneficiarieList)
            {
                System.Console.WriteLine($"{beneficiary.RegisterID,-15}  |  {beneficiary.Name,-15}  |  {beneficiary.Age,-10}  |  {beneficiary.Age}  |  {beneficiary.Mobile,-15}  |  {beneficiary.City,-15}");
            }
            // CID2001	Covishield	50
            // CID2002	Covaccine	50


            VaccineDetails vaccine1 = new VaccineDetails(VaccineName.Covishield, 50);
            VaccineDetails vaccine2 = new VaccineDetails(VaccineName.Covaccine, 50);
            vaccineList.Add(vaccine1);
            vaccineList.Add(vaccine2);
            foreach (VaccineDetails vaccine in vaccineList)
            {
                System.Console.WriteLine($"{vaccine.VaccineID,-10}  |  {vaccine.VaccineName,-15}  |  {vaccine.NoOfDose}");
            }
            // VID3001	"BID1001","CID2001",1,new DateTime(2022,11,11))
            // VID3002	"BID1001","CID2001",2,new DateTime(2023,03,11)
            // VID3003	"BID1002","CID2002"	,1 ,new DateTime(2023,04,04)

            VaccinationDetails vaccination1 = new VaccinationDetails("BID1001", "CID2001", 1, new DateTime(2022, 11, 11));
            VaccinationDetails vaccination2 = new VaccinationDetails("BID1001", "CID2001", 2, new DateTime(2023, 03, 11));
            VaccinationDetails vaccination3 = new VaccinationDetails("BID1002", "CID2002", 1, new DateTime(2023, 04, 04));
            vaccinationList.Add(vaccination1);
            vaccinationList.Add(vaccination2);
            vaccinationList.Add(vaccination3);
            foreach (VaccinationDetails vaccination in vaccinationList)
            {
                System.Console.WriteLine($"{vaccination.VaccinationID,-10}  |  {vaccination.RegisterID,-10}  |  {vaccination.VaccineID,-10}  |  {vaccination.DoseNumber}  |  {vaccination.VaccinationDate.ToString("dd/MM/yyyy"),-15}");
            }

        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Vaccination Drive Application");
                System.Console.WriteLine("1.Beneficiary Registration\n2. User Login\n 3. GetVaccine Info \n 4.Exit");
                int mainMenu = int.Parse(Console.ReadLine());
                switch (mainMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("Registration Selected");
                            Registr();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("login Selected");
                            Login();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("GetVaccineInfo");
                            GetVaccineInfo();
                            break;
                        }

                    case 4:
                        {
                            System.Console.WriteLine("Exit Selected");
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void Registr()
        {
            System.Console.WriteLine("Registration");
            System.Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Your Age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Gender:");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter Your Mobile:");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your City");
            string city = Console.ReadLine();
            BeneficiaryDetails beneficiary = new BeneficiaryDetails(name, age, gender, mobile, city);
            System.Console.WriteLine("Registration Successfully! Your ID is:" + beneficiary.RegisterID);
            beneficiarieList.Add(beneficiary);



        }
        public static void Login()
        {
            Console.WriteLine("Enter your user Id");
            string userID = Console.ReadLine().ToUpper();
            int flag = 1;
            foreach (BeneficiaryDetails beneficiary in beneficiarieList)
            {
                if (userID == beneficiary.RegisterID)
                {
                    flag = 0;
                    Console.WriteLine("Login Sucess Full");
                    currentLoginUser = beneficiary;
                    SubMenu();
                    break;

                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Invalid User Id.Please enter a valid one");
            }

        }
        public static void GetVaccineInfo()
        {
            // Show the available vaccine name and count details in the current date to plan your vaccination today.

            foreach (VaccineDetails vaccine in vaccineList)
            {
                System.Console.WriteLine($"{vaccine.VaccineID,-10}  |  {vaccine.VaccineName,-15}  |  {vaccine.NoOfDose}");
            }

        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {



                System.Console.WriteLine("a.ShowMyDetails.\nb.Take Vaccination: \n c.MyVaccination History. \n d.NextdueDate. \n e. exit");
                char SubMenu = char.Parse(Console.ReadLine());
                switch (SubMenu)
                {
                    case 'a':
                        {
                            Console.WriteLine("ShowMyDetails.");
                            ShowMyDetails();
                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine("Take Vaccination");
                            TakeVaccination();

                            break;
                        }
                    case 'c':
                        {
                            System.Console.WriteLine("MyVaccination History: ");
                            MyVaccinationHistory();
                            break;
                        }

                    case 'd':
                        {
                            System.Console.WriteLine("NextdueDate : ");
                            NextdueDate();
                            break;
                        }

                    case 'e':
                        {
                            Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }

                }
            } while (flag);
        }

        public static void ShowMyDetails()
        {
            // Show the current beneficiary’s personal details in console.
            foreach (BeneficiaryDetails beneficiary in beneficiarieList)
            {
                if (currentLoginUser.RegisterID == beneficiary.RegisterID)
                {
                    System.Console.WriteLine($"{beneficiary.RegisterID,-15}  |  {beneficiary.Name,-15}  |  {beneficiary.Age,-10}  |  {beneficiary.Age}  |  {beneficiary.Mobile,-15}  |  {beneficiary.City,-15}");
                }

            }

        }
        public static void TakeVaccination()
        {
            // // Show the list of vaccine available and to select a vaccine.
            // foreach (VaccineDetails vaccine in vaccineList)
            // {
            //     System.Console.WriteLine($"{vaccine.VaccineID,-10}  |  {vaccine.VaccineName,-15}  |  {vaccine.NoOfDose}");
            // }
            // // •	Ask the user to select a vaccine by using vaccine ID and find the ID is valid. 
            // System.Console.WriteLine("Enter Vaccine ID for vaccinate:");
            // string vaccineID = Console.ReadLine();
            // bool flag = true;
            // foreach (VaccineDetails vaccine in vaccineList)
            // {
            //     if (vaccineID == vaccine.VaccineID)
            //     //if(currentLoginUser.RegisterID==currentLoginUser.)
            //     {
            //         foreach (VaccinationDetails vaccination in vaccinationList)
            //         {
            //             // o	Then, get the vaccination history of current logged in beneficiary. 
            //             if (currentLoginUser.RegisterID == vaccination.RegisterID)
            //             {
            //                 System.Console.WriteLine($"{vaccination.VaccinationID,-10}  |  {vaccination.RegisterID,-10}  |  {vaccination.VaccineID,-10}  |  {vaccination.DoseNumber}  |  {vaccination.VaccinationDate.ToString("dd/MM/yyyy"),-15}");
            //             }
            //             // 	If he didn’t take any vaccine means check his age is above 14. 
            //             //vaccination.DoseNumber=0;
            //             else if (vaccination.DoseNumber < 1)
            //             {
            //                 if (currentLoginUser.Age >= 14)
            //                 {
            //                     // 	If yes, then allow him to take that vaccine.
            //                     System.Console.WriteLine("your Eligible for Vaccine");
            //                     // •	Update the details in his vaccination history list
            //                     // •	Deduct the count of vaccine available. 
            //                     vaccination.DoseNumber += 1;
            //                     System.Console.WriteLine($"{vaccination.VaccinationID,-10}  |  {vaccination.RegisterID,-10}  |  {vaccination.VaccineID,-10}  |  {vaccination.DoseNumber}  |  {DateTime.Now.ToString("dd/MM/yyyy"),-15}");
            //                     vaccine.NoOfDose = vaccine.NoOfDose - 1;
            //                     VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
            //                     vaccineList.Add(vaccine1);

            //                 }
            //             }
            //             // o	If he took three vaccines means show “All the three Vaccination are completed, you cannot be vaccinated now”.
            //             else if (vaccination.DoseNumber == 3)
            //             {
            //                 System.Console.WriteLine("All the three Vaccination are completed, you cannot be vaccinated now");
            //             }
            //             // o	If he took one or two vaccines in his vaccination history, then
            //             else if (vaccination.DoseNumber == 1)
            //             {
            //                 //find that he had selected the same vaccine type now.    
            //                 // 	If it is yes, then check date of his last vaccination and find whether 30 days have completed. 
            //                 TimeSpan check = DateTime.Now - vaccination.VaccinationDate;

            //                 if (check.TotalDays > 30)
            //                 {
            //                     vaccination.DoseNumber += 1;
            //                     System.Console.WriteLine($"{vaccination.VaccinationID,-10}  |  {vaccination.RegisterID,-10}  |  {vaccination.VaccineID,-10}  |  {vaccination.DoseNumber}  |  {DateTime.Now.ToString("dd/MM/yyyy"),-15}");
            //                     vaccine.NoOfDose = vaccine.NoOfDose - 1;
            //                     VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
            //                     vaccineList.Add(vaccine1);
            //                     System.Console.WriteLine($"Next elegible date:{DateTime.Now.AddDays(30)}");
            //                 }
            //                 else
            //                 {
            //                     System.Console.WriteLine($"Next eleigble date is:{vaccination.VaccinationDate.AddDays(30)}");
            //                 }

            //             }
            //             else if (vaccination.DoseNumber == 2)
            //             {
            //                 //find that he had selected the same vaccine type now.    
            //                 // 	If it is yes, then check date of his last vaccination and find whether 30 days have completed. 
            //                 // •	If it is yes, then allow him to take vaccination.
            //                 // •	Add the details to his vaccination list 
            //                 // •	Deduct the count of vaccine available.
            //                 TimeSpan check = DateTime.Now - vaccination.VaccinationDate;

            //                 if (check.TotalDays > 30)
            //                 {
            //                     vaccination.DoseNumber += 1;
            //                     System.Console.WriteLine($"{vaccination.VaccinationID,-10}  |  {vaccination.RegisterID,-10}  |  {vaccination.VaccineID,-10}  |  {vaccination.DoseNumber}  |  {DateTime.Now.ToString("dd/MM/yyyy"),-15}");
            //                     vaccine.NoOfDose = vaccine.NoOfDose - 1;
            //                     VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
            //                     vaccineList.Add(vaccine1);
            //                     VaccinationDetails vaccination1 = new VaccinationDetails(currentLoginUser.RegisterID, vaccination.VaccineID, vaccination.DoseNumber, DateTime.Now);
            //                 }
            //                 else
            //                 {
            //                     System.Console.WriteLine($"Next eleigble date is:{vaccination.VaccinationDate.AddDays(30)}");
            //                 }

            //             }

            //         }
            //     }
            // }
            // if (flag)
            // {
            //     System.Console.WriteLine("You have selected different vaccine”. You can vaccine with “Covaccine / Covishield (His first / second dose vaccine type)”  take vaccination process again");
            // }


            // Show the list of vaccine available and to select a vaccine.
            foreach (VaccineDetails vaccine in vaccineList)
            {
                System.Console.WriteLine($"{vaccine.VaccineID,-10}  |  {vaccine.VaccineName,-15}  |  {vaccine.NoOfDose}");
            }
            // •	Ask the user to select a vaccine by using vaccine ID and find the ID is valid. 
            System.Console.WriteLine("Do you take vaccine already yes or no");
            string option = Console.ReadLine().ToUpper();
            if (option == "Yes")
            {

                System.Console.WriteLine("Enter Vaccine ID for vaccinate:");
                string vaccineID = Console.ReadLine();
                bool flag = true;
                foreach (VaccinationDetails vaccination in vaccinationList)
                {
                    if (vaccineID == vaccination.VaccineID)
                    {
                        flag = false;

                        int max = 0;
                        foreach (VaccinationDetails vaccination2 in vaccinationList)
                        {
                            if (currentLoginUser.RegisterID == vaccination2.RegisterID && vaccination2.DoseNumber > max)
                            {
                                max = vaccination2.DoseNumber;
                            }
                        }
                        if (vaccineID == vaccination.VaccineID && currentLoginUser.RegisterID == vaccination.RegisterID)
                        {

                            if (max == 1)
                            {
                                //find that he had selected the same vaccine type now.    
                                // 	If it is yes, then check date of his last vaccination and find whether 30 days have completed. 
                                TimeSpan check = DateTime.Now - vaccination.VaccinationDate;

                                if (check.TotalDays > 30)
                                {
                                    foreach (VaccineDetails vaccine in vaccineList)
                                    {
                                        if (vaccine.VaccineID == vaccineID)
                                        {
                                            vaccine.NoOfDose = vaccine.NoOfDose - 1;

                                            //VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
                                            // vaccineList.Add(vaccine1);

                                            break;
                                        }
                                    }

                                    max += 1;
                                    VaccinationDetails vaccination1 = new VaccinationDetails(currentLoginUser.RegisterID, vaccineID, max, DateTime.Now);
                                    vaccinationList.Add(vaccination1);
                                    System.Console.WriteLine($"{vaccination1.VaccinationID,-10},  |  {currentLoginUser.RegisterID,-10}  |  {vaccineID,-10}  |  {max,-10}  |  {DateTime.Now.ToString("dd/MM/yyyy")}");
                                    System.Console.WriteLine($"Next elegible date:{DateTime.Now.AddDays(30)}");

                                }
                                else
                                {
                                    System.Console.WriteLine($"Next eleigble date is:{vaccination.VaccinationDate.AddDays(30)}");
                                }

                            }
                            else if (max == 2)
                            {
                                //find that he had selected the same vaccine type now.    
                                // 	If it is yes, then check date of his last vaccination and find whether 30 days have completed. 
                                TimeSpan check = DateTime.Now - vaccination.VaccinationDate;

                                if (check.TotalDays > 30)
                                {
                                    foreach (VaccineDetails vaccine in vaccineList)
                                    {
                                        if (vaccine.VaccineID == vaccineID)
                                        {
                                            vaccine.NoOfDose = vaccine.NoOfDose - 1;
                                            //VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
                                            // vaccineList.Add(vaccine1);
                                            break;
                                        }
                                    }

                                    max += 1;
                                    VaccinationDetails vaccination1 = new VaccinationDetails(currentLoginUser.RegisterID, vaccineID, max, DateTime.Now);
                                    vaccinationList.Add(vaccination1);
                                    System.Console.WriteLine($"{vaccination1.VaccinationID,-10},  |  {currentLoginUser.RegisterID,-10}  |  {vaccineID,-10}  |  {max,-10}  |  {DateTime.Now.ToString("dd/MM/yyyy")}");
                                    if (max == 3)
                                        System.Console.WriteLine($"You have completed all vaccination. Thanks for your participation in the vaccination drive");
                                }
                                // else
                                // {
                                //     System.Console.WriteLine($"Next eleigble date is:{vaccination.VaccinationDate.AddDays(30)}");
                                // }

                            }
                            else if (max == 3)
                            {
                                System.Console.WriteLine("All the three Vaccination are completed, you cannot be vaccinated now");
                            }
                        }


                        // else
                        // {
                        //     //flag = true;
                        //     if (currentLoginUser.Age > 14)
                        //     {
                        //         System.Console.WriteLine("your Eligible for Vaccine");
                        //         // •	Update the details in his vaccination history list
                        //         // •	Deduct the count of vaccine available. 
                        //         foreach (VaccineDetails vaccine in vaccineList)
                        //         {
                        //             if (vaccine.VaccineID == vaccineID)
                        //             {
                        //                 vaccine.NoOfDose = vaccine.NoOfDose - 1;
                        //                 //VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
                        //                 // vaccineList.Add(vaccine1);
                        //                 break;
                        //             }
                        //         }

                        //         max += 1;
                        //         VaccinationDetails vaccination1 = new VaccinationDetails(currentLoginUser.RegisterID, vaccineID, max, DateTime.Now);
                        //         vaccinationList.Add(vaccination1);
                        //         System.Console.WriteLine($"{vaccination1.VaccinationID,-10},  |  {currentLoginUser.RegisterID,-10}  |  {vaccineID,-10}  |  {max,-10}  |  {DateTime.Now.ToString("dd/MM/yyyy")}");
                        //         System.Console.WriteLine("Next elegible date" + DateTime.Now.AddDays(30));

                        //     }

                        // }
                        break;
                    }
                    // else
                    // {
                    //     int max = 0;
                    //     if (currentLoginUser.Age > 14)
                    //     {
                    //         System.Console.WriteLine("your Eligible for Vaccine");
                    //         // •	Update the details in his vaccination history list
                    //         // •	Deduct the count of vaccine available. 
                    //         foreach (VaccineDetails vaccine in vaccineList)
                    //         {
                    //             if (vaccine.VaccineID == vaccineID)
                    //             {
                    //                 vaccine.NoOfDose = vaccine.NoOfDose - 1;
                    //                 //VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
                    //                 // vaccineList.Add(vaccine1);
                    //                 break;
                    //             }
                    //         }

                    //         max += 1;
                    //         VaccinationDetails vaccination1 = new VaccinationDetails(currentLoginUser.RegisterID, vaccineID, max, DateTime.Now);
                    //         vaccinationList.Add(vaccination1);
                    //         System.Console.WriteLine($"{vaccination1.VaccinationID,-10},  |  {currentLoginUser.RegisterID,-10}  |  {vaccineID,-10}  |  {max,-10}  |  {DateTime.Now.ToString("dd/MM/yyyy")}");
                    //         System.Console.WriteLine("Next elegible date" + DateTime.Now.AddDays(30));

                    //     }
                    //     break;

                
                // else
                // {
                //     System.Console.WriteLine("You have selected different vaccine”. You can vaccine with “Covaccine / Covishield (His first / second dose vaccine type)”  take vaccination process again"); 
                // }



            }
            if (flag)
            {
                System.Console.WriteLine("You have selected different vaccine”. You can vaccine with “Covaccine / Covishield (His first / second dose vaccine type)”  take vaccination process again");
                foreach (VaccinationDetails vaccination in vaccinationList)
                {
                    if (vaccineID == vaccination.VaccineID)
                    {

                    }
                }
            }
        }
        else
        {
             int max = 0;
                        if (currentLoginUser.Age > 14)
                        {
                            System.Console.WriteLine("your Eligible for Vaccine");

                            System.Console.WriteLine("Select Vaccine for vaccination CID2001 / CID2002");
                            string vaccineID=Console.ReadLine().ToUpper();
                            foreach(VaccineDetails vaccine in vaccineList)
                            {
                                if(vaccine.NoOfDose>0)
                                {
                                    vaccine.NoOfDose = vaccine.NoOfDose - 1;
                                    VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
                                    break;
                                }
                            }
                            
                            // •	Update the details in his vaccination history list
                            // •	Deduct the count of vaccine available. 
                            // foreach (VaccineDetails vaccine in vaccineList)
                            // {
                            //     if (vaccine.VaccineID == vaccineID)
                            //     {
                            //         vaccine.NoOfDose = vaccine.NoOfDose - 1;
                            //         //VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
                            //         // vaccineList.Add(vaccine1);
                            //         break;
                            //     }
                            // }

                            max += 1;
                            VaccinationDetails vaccination1 = new VaccinationDetails(currentLoginUser.RegisterID, vaccineID, max, DateTime.Now);
                            vaccinationList.Add(vaccination1);
                            System.Console.WriteLine($"{vaccination1.VaccinationID,-10},  |  {currentLoginUser.RegisterID,-10}  |  {vaccineID,-10}  |  {max,-10}  |  {DateTime.Now.ToString("dd/MM/yyyy")}");
                            System.Console.WriteLine("Next elegible date" + DateTime.Now.AddDays(30));

                        }
        }
    }
    //         int max=0;
    //          if(currentLoginUser.Age>14)
    //                 {
    //                     System.Console.WriteLine("your Eligible for Vaccine");
    //                 // •	Update the details in his vaccination history list
    //                 // •	Deduct the count of vaccine available. 
    //                 foreach (VaccineDetails vaccine in vaccineList)
    //                 {
    //                     if (vaccine.VaccineID == vaccineID)
    //                     {
    //                         vaccine.NoOfDose = vaccine.NoOfDose - 1;
    //                         //VaccineDetails vaccine1 = new VaccineDetails(vaccine.VaccineName, vaccine.NoOfDose);
    //                        // vaccineList.Add(vaccine1);
    //                         break;
    //                     }
    //                 }

    //                 max += 1;
    //                 VaccinationDetails vaccination1 = new VaccinationDetails(currentLoginUser.RegisterID, vaccineID, max, DateTime.Now);
    //                 vaccinationList.Add(vaccination1);
    //                 System.Console.WriteLine($"{vaccination1.VaccinationID,-10},  |  {currentLoginUser.RegisterID,-10}  |  {vaccineID,-10}  |  {max,-10}  |  {DateTime.Now.ToString("dd/MM/yyyy")}");
    //                 System.Console.WriteLine("Next elegible date" + DateTime.Now.AddDays(30));

    //                 }
    //     }
    //     else
    //         {
    //             System.Console.WriteLine("You have selected different vaccine”. You can vaccine with “Covaccine / Covishield (His first / second dose vaccine type)”  take vaccination process again"); 
    //         }
    //     // 	If it is no, then show “You have selected different vaccine”. You can vaccine with “Covaccine / Covishield (His first / second dose vaccine type)”  take vaccination process again.  

    // }
    public static void MyVaccinationHistory()
    {
        //Show the vaccination details of the current beneficiary if he had completed first/ second/ third vaccinations
        foreach (VaccinationDetails vaccination in vaccinationList)
        {
            if (currentLoginUser.RegisterID == vaccination.RegisterID)
            {
                System.Console.WriteLine($"{vaccination.VaccinationID,-10}  |  {vaccination.RegisterID,-10}  |  {vaccination.VaccineID,-10}  |  {vaccination.DoseNumber}  |  {vaccination.VaccinationDate.ToString("dd/MM/yyyy"),-15}");
            }
        }

    }
    public static void NextdueDate()
    {
        foreach (VaccinationDetails vaccination in vaccinationList)
        {
            // •	If he completed the third dose, display “You have completed all vaccination. Thanks for your participation in the vaccination drive.”
            // if(currentLoginUser.RegisterID==vaccination.RegisterID)
            // {
            //      
            //       else if(vaccination.DoseNumber<3)
            // }

            //if (currentLoginUser.RegisterID == vaccination.RegisterID)

            //{
            int max = 0;
            foreach (VaccinationDetails vaccination2 in vaccinationList)
            {
                if (currentLoginUser.RegisterID == vaccination2.RegisterID && vaccination2.DoseNumber > max)
                {
                    max = vaccination2.DoseNumber;
                }
            }


            if (max == 3)
            {
                System.Console.WriteLine("You have completed all vaccination. Thanks for your participation in the vaccination drive");
                break;
            }
            else if (max == 1)//|| vaccination.DoseNumber==2) 

            {
                TimeSpan check = DateTime.Now - vaccination.VaccinationDate;
                if (check.TotalDays > 30)
                {
                    // vaccination.VaccinationDate=vaccination.VaccinationDate.AddDays(30);
                    System.Console.WriteLine($"Next elegible date:{DateTime.Now.AddDays(30)}");
                }
                else
                {
                    System.Console.WriteLine($"Next eleigble date is:{vaccination.VaccinationDate.AddDays(30)}");
                }
                break;
            }
            else if (max == 2)//|| vaccination.DoseNumber==2) 

            {
                TimeSpan check = DateTime.Now - vaccination.VaccinationDate;
                if (check.TotalDays > 30)
                {
                    // vaccination.VaccinationDate=vaccination.VaccinationDate.AddDays(30);
                    System.Console.WriteLine($"Next elegible date:{DateTime.Now.AddDays(30)}");
                }
                else
                {
                    System.Console.WriteLine($"Next eleigble date is:{vaccination.VaccinationDate.AddDays(30)}");
                }
                break;
            }
            // else
            // {
            //     System.Console.WriteLine();
            // }




            //}
            // •	Show the next due date for the current beneficiary by finding his details from his vaccination history. 

            else
            // •	If he didn’t take any dose already. Then show “you can take vaccine now”. 
            {
                System.Console.WriteLine("you can take vaccine now");
            }
            // •	If either first or second dose of vaccine completed means Add 30 days to find the next due date to vaccine.

        }


    }
}

}