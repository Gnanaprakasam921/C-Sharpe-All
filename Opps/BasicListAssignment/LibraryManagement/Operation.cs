using System;
using System.Collections.Generic;
using System.Globalization;

namespace LibraryManagement
{

    public class Operation
    {
        static List<UserDetails> userList = new List<UserDetails>();
        static List<BookDetail> bookList = new List<BookDetail>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static UserDetails currentLoginUser;
        public static void AddDEfaultValue()
        {


            UserDetails user1 = new UserDetails("Ravichandran", Gender.Male, Department.EEE, 9938388333, "ravi@gmail.com", 100);
            UserDetails user2 = new UserDetails("Priyadharshini", Gender.Female, Department.CSE, 9944444455, "priya@gmail.com", 150);
            userList.Add(user1);
            userList.Add(user2);
            foreach (UserDetails user in userList)
            {
                System.Console.WriteLine($"{user.UserID,-1}  |  {user.UserName,-15}  |  {user.Gender,-10}  |   {user.Department,-10}  |  {user.Mobile,-15}  |  {user.MailID,-15}  |  {user.WalletBalance,-10}");
            }
            BookDetail book1 = new BookDetail("C#", "Author1", 3);
            BookDetail book2 = new BookDetail("HTML", "Author2", 5);
            BookDetail book3 = new BookDetail("CSS", "Author1", 3);
            BookDetail book4 = new BookDetail("JS", "Author1", 3);
            BookDetail book5 = new BookDetail("TS", "Author2", 2);
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);
            foreach (BookDetail book in bookList)
            {
                System.Console.WriteLine($"{book.BookID,-10}  |  {book.BookName,-10}  |  {book.AuthorName,-15}  |  {book.BookCount,-10}");
            }
            BorrowDetails borrow1 = new BorrowDetails("BID1001", "SF3001", new DateTime(2023, 09, 10), 2, Status.Borrowed, 0);
            BorrowDetails borrow2 = new BorrowDetails("BID1003", "SF3001", new DateTime(2023, 09, 12), 1, Status.Borrowed, 0);
            BorrowDetails borrow3 = new BorrowDetails("BID1004", "SF3001", new DateTime(2023, 09, 14), 1, Status.Returned, 16);
            BorrowDetails borrow4 = new BorrowDetails("BID1002", "SF3002", new DateTime(2023, 09, 11), 2, Status.Borrowed, 0);
            BorrowDetails borrow5 = new BorrowDetails("BID1005", "SF3002", new DateTime(2023, 09, 09), 1, Status.Returned, 20);
            borrowList.Add(borrow1);
            borrowList.Add(borrow2);
            borrowList.Add(borrow3);
            borrowList.Add(borrow4);
            borrowList.Add(borrow5);
            foreach (BorrowDetails borrow in borrowList)
            {
                System.Console.WriteLine($"{borrow.BorrowID,-10}  |  {borrow.BookID,-10}  |  {borrow.UserID,-10}  |  {borrow.CurrentDate.ToString("dd/MM/yyyy"),-15}  |  {borrow.BorrowBookCount}  |{borrow.Status,-10}  |  {borrow.PaidFineAmount}");
            }



        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Medical Shop Application");
                System.Console.WriteLine("1.User Registration\n2. User Login\n 3. Exit");
                int mainMenu = int.Parse(Console.ReadLine());
                switch (mainMenu)
                {
                    case 1:
                        {
                            Console.WriteLine("Registration Selected");
                            Register();
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
        public static void Register()
        {


            System.Console.WriteLine("User Registration:");
            System.Console.Write("Enter User Name:");
            string userName = Console.ReadLine();
            System.Console.WriteLine("Enter Your Gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter Your Department");
            Department department = Enum.Parse<Department>(Console.ReadLine(), true);

            System.Console.WriteLine("Enter your Phone:");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.Write("Enter mail Id:");
            string mailID = Console.ReadLine();
            UserDetails user = new UserDetails(userName, gender, department, mobile, mailID, 0);
            Console.WriteLine(" Register Sucess fully and  Id is" + user.UserID);
            userList.Add(user);

        }
        public static void Login()
        {
            Console.WriteLine("Enter your user Id");
            string userID = Console.ReadLine().ToUpper();
            int flag = 1;
            foreach (UserDetails user in userList)
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
                Console.WriteLine("Invalid User Id.Please enter a valid one");
            }

        }

        public static void SubMenu()
        {
            bool flag = true;
            Console.WriteLine("This is SubMenu");
            do
            {

                // 1.	Borrowbook.
                // 2.	ShowBorrowedhistory.
                // 3.	ReturnBooks
                // 4.	WalletRecharge 
                // 5.	Exit

                System.Console.WriteLine("a.Borrowbook.\nb.ShowBorrowedhistory: \n c.ReturnBooks. \n d.WalletRecharge . \n e. exit");
                char SubMenu = char.Parse(Console.ReadLine());
                switch (SubMenu)
                {
                    case 'a':
                        {
                            Console.WriteLine("Borrowbook.");
                            BorrowBook();
                            //currentLoginStudent.Average()
                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine("ShowBorrowedhistory");
                            ShowBorrowedHistory();

                            break;
                        }
                    case 'c':
                        {
                            System.Console.WriteLine("Return Book.: ");
                            ReturnBooks();
                            break;
                        }

                    case 'd':
                        {
                            System.Console.WriteLine("WalletRecharge : ");
                            WalletRecharge();
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
        public static void BorrowBook()
        {

            // 1.	Show the list of Books available by printing BookID, BookName, AuthorName, BookCount.
            foreach (BookDetail book in bookList)
            {
                System.Console.WriteLine($"{book.BookID,-10}  |  {book.BookName,-10}  |  {book.AuthorName,-15}  |  {book.BookCount,-10}");
            }
            // 2.	Then Ask the user to pick one book by Asking “Enter Book ID to borrow”.
            System.Console.WriteLine("Enter the Book ID for borrow");
            string bookID = Console.ReadLine();


            bool flag = true;
            foreach (BookDetail book in bookList)
            {
                // 3.	Check whether “BookID” is available or not. 
                if (bookID == book.BookID)
                {
                    flag = false;

                    //, else ask the user to “Enter the count of the book”. Then,
                    System.Console.WriteLine("Enter the count of the book.");
                    int bookCount = int.Parse(Console.ReadLine());
                    // 5.	Check the book count availability of the book selected. 
                    if (bookCount <= book.BookCount)
                    {
                        // 6.	If the book is available to borrow, 
                        // bool temp = true;
                        int count = 0;
                        foreach (BorrowDetails barrow in borrowList)
                        {
                            if (currentLoginUser.UserID == barrow.UserID && barrow.Status == Status.Borrowed)
                            {
                                count += barrow.BorrowBookCount;
                            }
                        }
                        // temp = false;
                        // o	need to check whether the user already have any borrowed book.
                        // Because user can have a maximum of only 3 borrowed books at a time. 
                        if (bookCount < 3)
                        {



                            if ((bookCount + count <= 3) && bookCount <= 3)
                            {
                                //int totalcount = barrow.BorrowBookCount + bookCount;
                                // 7.	Else allocate the book to the user and set status of the Booking Details as "Borrowed” 
                                // barrow.Status = Status.Borrowed;
                                //and set the “BorrowedDate” as today’s date and “PaidFineAmount” as 0. 
                                // o	Create the borrow Details object then store it and show “Book Borrowed successfully”.
                                BorrowDetails borrow = new BorrowDetails(bookID, currentLoginUser.UserID, DateTime.Now, bookCount, Status.Borrowed, 0);
                                borrowList.Add(borrow);
                                book.BookCount = book.BookCount - bookCount;

                                System.Console.WriteLine("Book Borrowed successfully");

                            }
                            else
                            {
                                // o	If the user’s already borrowed book count and requested book count exceeds 3 count, then show “You can have maximum of 3 borrowed books. Your already borrowed books count is {BorrowBookCount} and requested count is {Current Requested Count}, which exceeds 3 ”.
                                System.Console.WriteLine($" Your already borrowed books count is {count} and requested count is {bookCount}, which exceeds 3");

                            }
                        }
                        // o	If user having 3 borrowed books already then show “You have borrowed 3 books already”.
                        else
                        {
                            System.Console.WriteLine(" You have borrowed 3 books already");
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Books are not available for the selected count");
                        foreach (BorrowDetails borrow in borrowList)
                        {
                            if (bookID == borrow.BookID && borrow.Status == Status.Borrowed)
                            {
                                DateTime availableDate = borrow.CurrentDate.AddDays(15);
                                // o	Show “The book will be available on {borrowed date + 15 days}”.  

                                //And print the next available date of book by getting that book’s “BorrowedDate” from the borrowed history information and adding with 15 days  the borrowed date of that book. 
                                System.Console.WriteLine($"This Book Temporary Unavialable. The book will be available on{availableDate.ToString("dd/MM/yyyy")}");
                            }
                        }
                    }
                }
            }

            // 4.	If not available display “ Invalid Book ID, Please enter valid ID”,
            if (flag)
            {
                System.Console.WriteLine("Invalid Book ID, Please enter valid ID");
            }


        }
        public static void ShowBorrowedHistory()
        {
            //Show the Book borrowed details of the current user.
            bool flag=true;
            foreach (BorrowDetails borrow in borrowList)
            {
                if (borrow.UserID == currentLoginUser.UserID)
                {
                    flag=false;
                    System.Console.WriteLine($"{borrow.BorrowID,-10}  |  {borrow.BookID,-10}  |  {borrow.UserID,-10}  |  {borrow.CurrentDate,-15}  |  {borrow.BorrowBookCount,-10}  |  {borrow.Status,-10}  |  {borrow.PaidFineAmount}");
                }
            }
            if(flag)
            {
                System.Console.WriteLine("No any borrow History");
            }
        }
        public static void ReturnBooks()
        {
           
            // 1.	Show the borrowed book details of current user whose status is “borrowed” 
            // bool flag=true;
            //     foreach (BorrowDetails borrow in borrowList)
            //     {
            //         if (borrow.UserID == currentLoginUser.UserID && borrow.Status == Status.Borrowed)
            //         {


            //             System.Console.WriteLine($"{borrow.BorrowID,-10}  |  {borrow.BookID,-10}  |  {borrow.UserID,-10}  |  {borrow.CurrentDate,-15}  |  {borrow.BorrowBookCount,-10}  |  {borrow.Status,-10}  |  {borrow.PaidFineAmount}");

            //             //also Print the return date of each book (Return date will be 15 days after borrowing a book).  
            //             System.Console.WriteLine(borrow.CurrentDate.AddDays(15).ToString("dd/MM/yyyy"));

            //             TimeSpan date = DateTime.Now - borrow.CurrentDate;
            //             int day = date.Days;
            //             if (day > 15)
            //             {
            //                 // 2.	If the return date is elapsed more than 15 days then calculate and show the fine amount (Rs. 1 / Day) for each book.
            //                 int totalFineAmount = day * 1;
            //                 System.Console.WriteLine(totalFineAmount);
            //                 // 3.	Ask him to select the BorrowedID to return book and validate that ID.
            //                 System.Console.WriteLine("Enter the BookId to return:");
            //                 string bookID = Console.ReadLine();
            //                 // 4.	If return date is elapsed, 
            //                 if (bookID == borrow.BookID)
            //                 {
            //                     // a.	then check whether the user have sufficient balance for the fine amount, 
            //                     if (currentLoginUser.WalletBalance >= totalFineAmount)
            //                     {
            //                         // b.	if he has sufficient balance then deduct the fine amount from his Wallet balance 
            //                         currentLoginUser.WalletBalance = currentLoginUser.WalletBalance - totalFineAmount;
            //                         //and change the Status in Booking History to “Returned”
            //                         borrow.Status = Status.Returned;
            //                         borrow.BorrowBookCount++;
            //                         // and update the fine amount to the “PaidFineAmount” calculated and show “Book returned successfully”. Also, update the “BookCount”.
            //                         System.Console.WriteLine($"Book returned successfully.Book count is{borrow.BorrowBookCount}");
            //                         break;
            //                     }
            //                     // c.	else show “Insufficient balance. Please rechange and proceed”. 
            //                     else
            //                     {
            //                         System.Console.WriteLine("Insufficient balance. Please rechange!");
            //                     }
            //                 }
            //                 else
            //                 {
            //                     System.Console.WriteLine("Invalid Book ID:");
            //                 }
            //             }

            //         }
            //     }

            foreach (BorrowDetails borrow in borrowList)
            {
                // 1.	Show the borrowed book details of current user whose status is “borrowed”     //also Print the return date of each book (Return date will be 15 days after borrowing a book). 
                if (currentLoginUser.UserID == borrow.UserID && borrow.Status == Status.Borrowed)
                {
                    if (borrow.CurrentDate.AddDays(15) < DateTime.Now)
                    {
                        // 2.	If the return date is elapsed more than 15 days then calculate and show the fine amount (Rs. 1 / Day) for each book.
                        int differ = (DateTime.Now - borrow.CurrentDate).Days;
                        int fineAmount = differ * 1;
                        System.Console.WriteLine($"{borrow.BorrowID,-10}  |  {borrow.BookID,-10}  |  {borrow.UserID,-10}  |  {borrow.CurrentDate.ToString("dd/MM/yyyy"),-15}  |  {borrow.BorrowBookCount}  |{borrow.Status,-10}  |  {borrow.PaidFineAmount,-10} | Return date:{borrow.CurrentDate.AddDays(15),-15}   |  Fine:{fineAmount}");
                    }
                    else
                    {
                        System.Console.WriteLine($"{borrow.BorrowID,-10}  |  {borrow.BookID,-10}  |  {borrow.UserID,-10}  |  {borrow.CurrentDate.ToString("dd/MM/yyyy"),-15}  |  {borrow.BorrowBookCount}  |{borrow.Status,-10}  |  {borrow.PaidFineAmount,-10} | Return date:{borrow.CurrentDate.AddDays(15),-15}");
                    }

                }


            }
            // 3.	Ask him to select the BorrowedID to return book and validate that ID. 
            System.Console.WriteLine("Enter borrow ID");
            string borrowedID = Console.ReadLine();
            foreach (BorrowDetails borrow1 in borrowList)
            {


                if (currentLoginUser.UserID == borrow1.UserID && borrow1.Status == Status.Borrowed)
                {
                    // 4.	If return date is elapsed, 
                    if (borrow1.CurrentDate.AddDays(15) < DateTime.Now)
                    {


                        int differ = (DateTime.Now - borrow1.CurrentDate).Days;
                        int fineAmount = differ * 1;
                        // a.	then check whether the user have sufficient balance for the fine amount, 
                        if (fineAmount <= currentLoginUser.WalletBalance)
                        {

                            // b.	if he has sufficient balance then deduct the fine amount from his Wallet balance and change the Status in Booking History to “Returned” and update the fine amount to the “PaidFineAmount” calculated and show “Book returned successfully”. Also, update the “BookCount”.
                            currentLoginUser.WalletBalance = currentLoginUser.WalletBalance - fineAmount;
                            borrow1.Status = Status.Returned;
                            borrow1.PaidFineAmount = fineAmount;

                            foreach (BookDetail book in bookList)
                            {
                                if (book.BookID == borrow1.BookID)
                                {
                                    book.BookCount = book.BookCount + borrow1.BorrowBookCount;
                                }
                            }
                            System.Console.WriteLine("Borrowed Successfully");
                            // BorrowDetails borrow=new BorrowDetails(borrowedID,currentLoginUser.UserID,DateTime.Now.ToString("dd/MM/yyyy"),)
                        }
                        // c.	else show “Insufficient balance. Please rechange and proceed”. 
                        else
                        {
                            System.Console.WriteLine("Insufficient balance. Please rechange and proceed");
                        }

                    }
                    // 5.	Else, change the Status in Booking History to “Returned” and show Book returned successfully. Also, update the “BookCount”.
                    else
                    {
                        borrow1.Status = Status.Returned;
                        foreach (BookDetail book in bookList)
                        {
                            if (book.BookID == borrow1.BookID)
                            {
                                book.BookCount = book.BookCount + borrow1.BorrowBookCount;
                            }
                        }
                        System.Console.WriteLine("Return Sucessfully");

                    }

                }
            }











        }
        public static void WalletRecharge()
        {
            // 1.	Ask the customer whether he wish to recharge the wallet. 
            Console.WriteLine("Do you want to Rechagre to the Wallet Yes Or No");
            string option = Console.ReadLine();
            // 2.	If “Yes” then ask for the amount to be recharged and update the amount in the wallet and display the updated wallet balance.
            if (option == "Yes")
                Console.Write("Enter your deposite amount:");
            int amount = int.Parse(Console.ReadLine());
            currentLoginUser.WalletRecharege(amount);
            System.Console.WriteLine(currentLoginUser.WalletBalance);
            // 3.	Else go the submenu.
        }
    }
}

