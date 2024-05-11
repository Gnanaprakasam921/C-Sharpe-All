using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace DTHRecharge
{
    public class Operation

    {
        static List<UserRegister> userList = new List<UserRegister>();
        static List<PackDetails> packList = new List<PackDetails>();
        static List<RechargeHistory> rechargeList = new List<RechargeHistory>();
        static UserRegister currentLoginUser;
        public static void AddDefaultData()
        {
            UserRegister user1 = new UserRegister("John", 9746646466, "john@gmail.com", 500);
            UserRegister user2 = new UserRegister("Merlin", 9743546368, "merlin@gmail.com", 150);
            userList.Add(user1);
            userList.Add(user2);
            PackDetails pack1 = new PackDetails("RC150", "Pack1", 150, 28, 50);
            PackDetails pack2 = new PackDetails("RC300", "Pack2", 300, 56, 75);
            PackDetails pack3 = new PackDetails("RC500", "Pack3", 500, 28, 200);
            PackDetails pack4 = new PackDetails("RC1500", "Pack4", 1500, 365, 200);
            packList.Add(pack1);
            packList.Add(pack2);
            packList.Add(pack3);
            packList.Add(pack4);
            RechargeHistory recharge1 = new RechargeHistory("UID1001", "RC150", new DateTime(2021, 11, 30), 150, new DateTime(2021, 12, 27), 50);
            RechargeHistory recharge2 = new RechargeHistory("UID1002", "RC150", new DateTime(2022, 01, 01), 150, new DateTime(2022, 01, 28), 50);
            rechargeList.Add(recharge1);
            rechargeList.Add(recharge2);
            foreach (UserRegister user in userList)
            {
                System.Console.WriteLine($"{user.UserID}  |  {user.UserName}  |  {user.Mobile}  |  {user.Email}  |  {user.WalletBalance}");
            }
            foreach (PackDetails pack in packList)
            {
                System.Console.WriteLine($"{pack.PackID}  |  {pack.PackName}  |  {pack.Price}  |  {pack.Validity}  |  {pack.NoOfChennal}");
            }
            foreach (RechargeHistory recharge in rechargeList)
            {
                System.Console.WriteLine($"{recharge.RechargeID}  |  {recharge.UserID}  |  {recharge.PackID}  |  {recharge.RechargeDate.ToString("dd/MM/yyyy")}  |  {recharge.RechargeAmount}  |  {recharge.ValidTill.ToString("dd/MM/yyyy")}  |  {recharge.NumberOfChennal}");
            }

        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.Write("DTH Recharge Application");
                System.Console.WriteLine("1.User Registration\n2. User Login\n 3.Exit");
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
                            Login();
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
            System.Console.WriteLine("User Registration:");
            System.Console.Write("Enter User Name:");
            string userName = Console.ReadLine();
            System.Console.WriteLine("Enter your Phone:");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.Write("Enter Your mail:");
            string mail = Console.ReadLine();
            //System.Console.WriteLine("");
            //double WalletBalance=double.Parse(Console.ReadLine());
            UserRegister user = new UserRegister(userName, mobile, mail, 0);
            Console.WriteLine(" Register Sucess fully and  Id is:" + user.UserID);
            userList.Add(user);
            Console.WriteLine("Do you want Continute:");
            string option = Console.ReadLine();
        }
        public static void Login()
        {
            Console.WriteLine("Enter your customer Id");
            string userID = Console.ReadLine().ToUpper();
            int flag = 1;
            foreach (UserRegister user in userList)
            {
                if (userID == user.UserID)
                {
                    flag = 0;
                    Console.WriteLine("Login Sucess Full");
                    currentLoginUser = user;
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

                System.Console.WriteLine("a.CurrentPack \nb.PackRecharge \n c.WallerRecharge \n d.ViewPackRechargeHistory \n e.ShowWalletBalance  \n f.Exit");
                char SubMenu = char.Parse(Console.ReadLine());
                switch (SubMenu)
                {
                    case 'a':
                        {
                            Console.WriteLine("CurrentPack");
                            CurrentPack();

                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine("PackRecharge:");
                            PackRecharge();

                            break;
                        }
                    case 'c':
                        {
                            System.Console.WriteLine("WallerRecharge: ");
                            WallerRecharge();
                            break;
                        }
                    case 'd':
                        {
                            System.Console.WriteLine("ViewPackRechargeHistory:");
                            ViewPackRechargeHistory();
                            break;
                        }
                    case 'e':
                        {
                            System.Console.WriteLine("ShowWalletBalance");
                            ShowWalletBalance();
                            break;
                        }
                    case 'f':
                        {
                            Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }

                }
            } while (flag);
        }

        public static void CurrentPack()
        {
            // 1.	Displays recent pack detail of current user (User ID, Pack ID, Recharge Amount, Valid Till, Number of channels)

            foreach (RechargeHistory recharge in rechargeList)
            {
                if (currentLoginUser.UserID == recharge.UserID && recharge.ValidTill >= DateTime.Now)
                {
                    System.Console.WriteLine($"{recharge.RechargeID}  |  {recharge.UserID}  |  {recharge.PackID}  |  {recharge.RechargeDate.ToString("dd/MM/yyyy")}  |  {recharge.RechargeAmount}  |  {recharge.ValidTill.ToString("dd/MM/yyyy")}  |  {recharge.NumberOfChennal}  |");
                    break;
                    //  Console.WriteLine($"{recharge.UserID}  |  {recharge.PackID}  |  {recharge.RechargeAmount}  |  {recharge.ValidTill}  |  {recharge.NumberOfChennal}");
                }

            }
        }

        public static void PackRecharge()
        {
            //  1.	List the available pack details 
            foreach (PackDetails pack in packList)
            {
                System.Console.WriteLine($"{pack.PackID}  |  {pack.PackName}  |  {pack.Price}  |  {pack.Validity}  |  {pack.NoOfChennal}");
            }
            // //  and ask the user to choose a pack and recharge.
            System.Console.WriteLine(" Choose the pack for the Recharge:");
            string selectedPack = Console.ReadLine();

            //  1.	List the available pack details and ask the user to choose a pack and recharge.\
            bool flag = true;
            foreach (PackDetails pack in packList)
            {
                // 2.	Based on the pack choose,
                if (selectedPack == pack.PackID)
                {
                    flag = false;

                    //check the wallet balance.
                    if (currentLoginUser.WalletBalance >= pack.Price)
                    {

                        // DateTime date = new DateTime();
                        // foreach (RechargeHistory recharge1 in rechargeList)
                        // {
                        //     if (currentLoginUser.UserID == recharge1.UserID)
                        //     {
                        //         date = recharge1.ValidTill;
                        //     }

                         DateTime date = new DateTime();
                        foreach (RechargeHistory recharge1 in rechargeList)
                        {
                            if(date<recharge1.ValidTill)
                            {
                                date=recharge1.ValidTill;
                            }
                        }
                        //if(date==)

                        //}
                        DateTime lastRecharge;
                        if (date >= DateTime.Today)
                        {
                           lastRecharge = DateTime.Now.Add(date - DateTime.Now).AddDays(pack.Validity);
                        }
                        else
                        {

                          lastRecharge= DateTime.Now.AddDays(pack.Validity - 1);

                        }
                        currentLoginUser.WalletBalance = currentLoginUser.WalletBalance - pack.Price;
                        RechargeHistory recharge = new RechargeHistory(currentLoginUser.UserID, pack.PackID, DateTime.Now, pack.Price,lastRecharge , pack.NoOfChennal);
                        rechargeList.Add(recharge);
                        System.Console.WriteLine("Recharge Sucessfully");

                        //DateTime date=new DateTime;

                        // 4.	If the user has sufficient balance, then permit and do recharge.
                        // foreach (RechargeHistory recharge1 in rechargeList)
                        // {
                        //     currentLoginUser.WalletBalance = currentLoginUser.WalletBalance - pack.Price;
                        //     RechargeHistory recharge = new RechargeHistory(currentLoginUser.UserID, pack.PackID, DateTime.Now, recharge1.RechargeAmount, DateTime.Now.AddDays(pack.Validity), pack.NoOfChennal);
                        //     rechargeList.Add(recharge);
                        //     System.Console.WriteLine("Recharge Sucessfully");
                        //     break;

                        // }
                    }

                    // 3.	If insufficient balance in wallet, ask them to recharge his wallet.
                    else
                    {
                        System.Console.WriteLine("Incufficient Balance Please Recharge your wallet. or Please select other Pack. ");
                    }
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Wrorng Pack Id Please Enter Valid.");
            }
        }

        public static void WallerRecharge()
        {

            //1.	Ask for the amount to be recharged from the user and update the wallet balance.
            Console.WriteLine("Do you want to Rechagre to the Wallet Yes Or No");
            string option = Console.ReadLine();



            if (option == "Yes")
            {
                Console.Write("Enter your deposite amount:");
                int amount = int.Parse(Console.ReadLine());
                currentLoginUser.WalletRecharege(amount);
                //System.Console.WriteLine(currentLoginUser.WalletBalance);
                System.Console.WriteLine("Rechared sucessFully, Your wallet ballance has been updated. Kindly check show Wallet Balance!");
            }
        }
        public static void ViewPackRechargeHistory()
        {
            bool flag=true;
            //1.	   List the history of recharge details of current user (UserID, PackID, Recharge Amount, Valid Till)
            foreach (RechargeHistory recharge in rechargeList)
            {
                if (currentLoginUser.UserID == recharge.UserID)
                {
                    flag=false;
                    System.Console.WriteLine($"{recharge.RechargeID}  |  {recharge.UserID}  |  {recharge.PackID}  |  {recharge.RechargeDate.ToString("dd/MM/yyyy")}  |  {recharge.RechargeAmount}  |  {recharge.ValidTill.ToString("dd/MM/yyyy")}  |  {recharge.NumberOfChennal}");
                }
            }
            if(flag)
            {
                System.Console.WriteLine("No pack History");
            }
        }

            public static void ShowWalletBalance()
            {
                //•	show the wallet balance of the current user

                System.Console.WriteLine(currentLoginUser.WalletBalance);
            }
        }
    }
