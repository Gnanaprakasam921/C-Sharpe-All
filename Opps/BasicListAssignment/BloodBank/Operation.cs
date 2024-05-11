using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BloodBank
{
    public class Operation
    {
        static List<Registration> userList = new List<Registration>();
        static List<Donation> donationList = new List<Donation>();
        static Registration currentLoginuser;
        public static void AddDefaultItem()
        {
            Registration user1 = new Registration("Ravichandran", 8484848, BloodGroup.O, 30, new DateTime(2022, 08, 25));
            Registration user2 = new Registration("Baskaran", 84873838, BloodGroup.A, 30, new DateTime(2022, 09, 30));
            userList.Add(user1);
            userList.Add(user2);
            Donation done1 = new Donation("UID1001", new DateTime(2022, 06, 10), 73, 120, 14, BloodGroup.O);
            Donation done2 = new Donation("UID1001", new DateTime(2023, 10, 10), 74, 120, 14, BloodGroup.O);
            Donation done3 = new Donation("UID1002", new DateTime(2022, 07, 11), 74, 120, 13.6, BloodGroup.AB);
            donationList.Add(done1);
            donationList.Add(done2);
            donationList.Add(done3);
            foreach (Registration user in userList)
            {
                Console.WriteLine($"{user.DonerID}  |  {user.DonerName}  |  {user.BloodGroup}  |  {user.Age}  |  {user.LastDonate.ToString("dd/MM/yyyy")}  |  {user.BloodGroup}");
            }
            foreach (Donation done in donationList)
            {
                Console.WriteLine($"{done.DonationID}  |  {done.DonerID}  |  {done.DonationDate}  |  {done.Weight}  |  {done.BloodPrasure}  |  {done.Hemoclobin}  |  {done.BloodGroup}");
            }

        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Blood Banking Application");
                System.Console.WriteLine("1.User Registration\n2. User Login\n 3.Fetch Detal \n 4. Exit");
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
                            System.Console.WriteLine("FetchDonerDetail:");
                            FechDonerDetail();
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
            System.Console.WriteLine("User Registration:");
            System.Console.Write("Enter Doner Name:");
            string donerName = Console.ReadLine();
            System.Console.WriteLine("Enter your Phone:");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.Write("Enter Your BloodGorup:");
            BloodGroup bloodGorup = Enum.Parse<BloodGroup>(Console.ReadLine(), true);

            System.Console.WriteLine("Enter Your age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Are you donate blood already Yes or No");
            string say=Console.ReadLine().ToUpper();
            DateTime lastDonate=new DateTime();
            if(say=="yes")
            {
            System.Console.WriteLine("Enter Your last blood donnation Date:");
            lastDonate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            }
            else
            {
                 lastDonate=new DateTime();
            }
           
            Registration user = new Registration(donerName, mobile, bloodGorup, age, lastDonate);
            Console.WriteLine(" Register Sucess fully and  Id is" + user.DonerID);
            userList.Add(user);
            Console.WriteLine("Do you want Continute:");
            string option = Console.ReadLine();
        }
        public static void Login()
        {
            Console.WriteLine("Enter your customer Id");
            string userID = Console.ReadLine().ToUpper();
            int flag = 1;
            foreach (Registration user in userList)
            {
                if (userID == user.DonerID)
                {
                    flag = 0;
                    Console.WriteLine("Login Sucess Full");
                    currentLoginuser = user;
                    SubMenu();
                    break;

                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Invalid User Id");
            }
        }
        public static void FechDonerDetail()
        {
            //     On selection of the “Fetch Donor Details” option from the main menu,
            // 1.	Ask for “Blood Group” and check blood group in the Donation details and it should display the donor’s name and phone number and native place.
            System.Console.WriteLine("Which Blood gruoup do you want:A or B or O or AB");
            BloodGroup bloodGroup = Enum.Parse<BloodGroup>(Console.ReadLine(), true);
            foreach (Registration user in userList)
            {

                if (bloodGroup == user.BloodGroup)
                {
                    Console.WriteLine($"{user.DonerID}  |  {user.DonerName}  |  {user.BloodGroup}  |  {user.Age}  |  {user.LastDonate.ToString("dd/MM/yyyy")}  |  {user.BloodGroup}");

                }

            }

            // On selection of the “Fetch Donor Details” option from the main menu
        }



        public static void SubMenu()
        {
            bool flag = true;
            Console.WriteLine("This is SubMenu");
            do
            {

                System.Console.WriteLine("a.DonateBlood \nb.DonationHistory: \n c.NextEligibleDate \n d.Exit");
                char SubMenu = char.Parse(Console.ReadLine());
                switch (SubMenu)
                {
                    case 'a':
                        {
                            Console.WriteLine("DonateBlood");
                            DonateBlood();
                            //currentLoginStudent.Average()
                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine("DonationHistory:");
                            DonationHistory();

                            break;
                        }
                    case 'c':
                        {
                            System.Console.WriteLine("NextEligibleDate: ");
                            NextEligibleDate();
                            break;
                        }
                    case 'd':
                        {
                            Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }

                }
            } while (flag);
        }

        public static void DonateBlood()
        {
            //  •	Get the weight, blood pressure, hemoglobin count from the user 
            System.Console.WriteLine("Enter Your Weight:");
            double weight = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your BloodPrasure:");
            double bloodPrasure = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Hemoclobe count:");
            double hemoclobin = double.Parse(Console.ReadLine());



            // check Weight is above 50, bp is below 130 hemoglobin count is above 13.
            if (weight > 50 && bloodPrasure < 130 && hemoclobin > 13 && currentLoginuser.Age > 18)
            {
                DateTime maximum = new DateTime();
                foreach (Donation done in donationList)
                {
                    if (done.DonationDate > maximum)
                    {
                        maximum = done.DonationDate;
                    }
                }
                TimeSpan differ = maximum - currentLoginuser.LastDonate;
                // •	Check whether the person’s completed 6 months after donating the blood.


                if (differ.TotalDays > 180)
                {

                    // •	If both the conditions met, then add the details to the “Donation Details” object and finally add to the list.
                    Donation done = new Donation(currentLoginuser.DonerID, DateTime.Now, weight, bloodPrasure, hemoclobin, currentLoginuser.BloodGroup);
                    donationList.Add(done);
                    // •	Finally show Blood donated successfully,
                    System.Console.WriteLine("donated successfully,");
                    //Show the donation ID And 
                    foreach (Donation done1 in donationList)
                    {
                        if (done1.DonerID == currentLoginuser.DonerID)
                        {
                            System.Console.WriteLine($"Your dondation ID is: {done1.DonationID}");
                        }
                    }
                  
                    DateTime nextDonate = DateTime.Now.AddDays(180);
                    System.Console.WriteLine($"Your Next eligible date: {nextDonate}");
                    //}
                }
                else
                {
                    System.Console.WriteLine("Your Not Eligible donate right Now:");
                    System.Console.WriteLine("Your Eligbile date:" + maximum.AddDays(180));
                }
            }
            else
            {
                System.Console.WriteLine("your Not elegible for Blood donate!");
            }
        }

        public static void DonationHistory()
        {
            bool flag=true;
            // Show the donation details of the current user using the method by traversing the donation history list.
            foreach (Donation done in donationList)
            {
                if (currentLoginuser.DonerID == done.DonerID)
                {
                    flag=false;
                    System.Console.WriteLine($"  {done.DonationID}   |  {currentLoginuser.DonerID}  | {done.DonationDate} |  {done.Weight}  |  {done.BloodPrasure}  |  {done.Hemoclobin}  | {done.BloodGroup} ");
                }

            }
            if(flag)
            {
                System.Console.WriteLine("No donation History");
            }
            // Donation done1 = new Donation(currentLoginuser.DonerID, DateTime.Now, , bloodPrasure, hemoclobin, BloodGroup.O);
            //   donationList.Add(done);


        }

        public static void NextEligibleDate()
        {
            // Show the next eligible date for the user (6 months from the date of last donation).
            DateTime maximum = new DateTime();
            foreach (Donation done in donationList)
            {
                if (done.DonationDate > maximum)
                {
                    maximum = done.DonationDate;
                }
            }
            TimeSpan differ = maximum - currentLoginuser.LastDonate;
            if(maximum==currentLoginuser.LastDonate)
            {
                System.Console.WriteLine("You did not donate Blood");
            }

           else if (differ.TotalDays > 180)

            {
                //System.Console.WriteLine(currentLoginuser.DonerID);
                // System.Console.WriteLine("Your Eligible for donate");
                DateTime nextDonate = maximum.AddDays(180);
                System.Console.WriteLine($"Your Next eligible date: {nextDonate.ToString("dd/MM/yyyy")}");
            }
            else if (differ.TotalDays < 180)
            {
                //System.Console.WriteLine("Your Not Eligible");
                DateTime nextDonate = maximum.AddDays(180);
                System.Console.WriteLine($"Your Next eligible date: {nextDonate}");
            }
            //  If the user donates 2 times, last donation must be user recently donated date. 

            // foreach (Donation done in donationList)
            // {
            //     if (done.DonationDate == currentLoginuser.LastDonate)
            //     {
            //         currentLoginuser.LastDonate = done.DonationDate;
            //     }
            // }
        }
    }

}

