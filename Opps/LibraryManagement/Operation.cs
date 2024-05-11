using System;
using System.Collections.Generic;
using System.Globalization;

namespace LibraryManagement
{

    public class Operation
    {
        static List<UserDetails> userList = new List<UserDetails>();
        static List<BookDetail> bookList = new List<BookDetail>();
        static List<BarrowDetails> borrowList = new List<BarrowDetails>();
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
            BarrowDetails borrow1 = new BarrowDetails("BID1001", "SF3001", new DateTime(2023, 09, 10), 2, Status.Borrowed, 0);
            BarrowDetails borrow2 = new BarrowDetails("BID1003", "SF3001", new DateTime(2023, 09, 12), 1, Status.Borrowed, 0);
            BarrowDetails borrow3 = new BarrowDetails("BID1004", "SF3001", new DateTime(2023, 09, 14), 1, Status.Returned, 16);
            BarrowDetails borrow4 = new BarrowDetails("BID1002", "SF3002", new DateTime(2023, 09, 11), 2, Status.Borrowed, 0);
            BarrowDetails borrow5 = new BarrowDetails("BID1005", "SF3002", new DateTime(2023, 09, 09), 1, Status.Returned, 20);
            borrowList.Add(borrow1);
            borrowList.Add(borrow2);
            borrowList.Add(borrow3);
            borrowList.Add(borrow4);
            borrowList.Add(borrow5);
            foreach (BarrowDetails borrow in borrowList)
            {
                System.Console.WriteLine($"{borrow.BorrowID,-10}  |  {borrow.BookID,-10}  |  {borrow.UserID,-10}  |  {borrow.CurrentDate,-15}  |  {borrow.BorrowBookCount}  |{borrow.Status,-10}  |  {borrow.PaidFineAmount}");
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
            System.Console.WriteLine("Enter the Book ID for Borrow");
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
                        int totalCount=0;
                        foreach (BarrowDetails barrow in borrowList)
                        {
                            if(currentLoginUser.UserID== barrow.UserID && barrow.Status==Status.Borrowed)
                            {
                                totalCount=totalCount+barrow.BorrowBookCount;
                            }
                        }
                        if(totalCount<3)
                        {
                            if(bookCount<=3 && (bookCount+totalCount)<=3)
                            {
                                 BarrowDetails borrow = new BarrowDetails(bookID, currentLoginUser.UserID, DateTime.Now, totalCount, Status.Borrowed, 0);
                                borrowList.Add(borrow);
                                book.BookCount=book.BookCount-bookCount;
                                System.Console.WriteLine("Borrowd Successfully");
                            }
                            else
                            {
                                System.Console.WriteLine($"You can have maximum of 3 borrowed books. you already borrowed 3 and requested count is {bookCount}, which exceeds 3");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("You have borrowed 3 books alreay");
                        }
                    }
                    else
                    {
                        foreach(BarrowDetails borrow in borrowList)
                        {
                            if(bookID==borrow.BookID)
                            {
                                System.Console.WriteLine($"This Book Temporary Unavialable.The book will be available on {borrow.CurrentDate.AddDays(15).ToString("dd/MM/yyyy")}");
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








            // o	If the user’s already borrowed book count and requested book count exceeds 3 count, then show “You can have maximum of 3 borrowed books. Your already borrowed books count is {BorrowBookCount} and requested count is {Current Requested Count}, which exceeds 3 ”.





        
        public static void ShowBorrowedHistory()
        {
            //Show the Book borrowed details of the current user.
            foreach (BarrowDetails borrow in borrowList)
            {
                if (borrow.UserID == currentLoginUser.UserID && borrow.Status == Status.Borrowed)
                {
                     System.Console.WriteLine($"{borrow.BorrowID,-10}  |  {borrow.BookID,-10}  |  {borrow.UserID,-10}  |  {borrow.CurrentDate,-15}  |  {borrow.BorrowBookCount,-10}  |  {borrow.Status,-10}  |  {borrow.PaidFineAmount}");
                }
            }
        }
        public static void ReturnBooks()
        {
            ShowBorrowedHistory();
            // 1.	Show the borrowed book details of current user whose status is “borrowed” 
            foreach (BarrowDetails borrow in borrowList)
            {
                if (borrow.UserID == currentLoginUser.UserID && borrow.Status == Status.Borrowed)
                {


                    System.Console.WriteLine($"{borrow.BorrowID,-10}  |  {borrow.BookID,-10}  |  {borrow.UserID,-10}  |  {borrow.CurrentDate,-15}  |  {borrow.BorrowBookCount,-10}  |  {borrow.Status,-10}  |  {borrow.PaidFineAmount}");

                    //also Print the return date of each book (Return date will be 15 days after borrowing a book).  
                    System.Console.WriteLine(borrow.CurrentDate.AddDays(15).ToString("dd/MM/yyyy"));
                    TimeSpan date = DateTime.Now - borrow.CurrentDate;
                    int day = date.Days;

                    if (day > 15)
                    {
                        // 2.	If the return date is elapsed more than 15 days then calculate and show the fine amount (Rs. 1 / Day) for each book.
                        int totalFineAmount = (day * 1) - 15;
                        System.Console.WriteLine(totalFineAmount);
                        // 3.	Ask him to select the BorrowedID to return book and validate that ID.
                        System.Console.WriteLine("Enter the BookId to return:");
                        string bookID = Console.ReadLine();
                        // 4.	If return date is elapsed, 
                        if (bookID == borrow.BookID)
                        {
                            // a.	then check whether the user have sufficient balance for the fine amount, 
                            if (currentLoginUser.WalletBalance >= borrow.PaidFineAmount)
                            {
                                // b.	if he has sufficient balance then deduct the fine amount from his Wallet balance 
                                currentLoginUser.WalletBalance = currentLoginUser.WalletBalance - borrow.PaidFineAmount;
                                //and change the Status in Booking History to “Returned”
                                borrow.Status = Status.Returned;
                                borrow.BorrowBookCount++;
                                // and update the fine amount to the “PaidFineAmount” calculated and show “Book returned successfully”. Also, update the “BookCount”.
                                System.Console.WriteLine($"Book returned successfully.Book count is{borrow.BorrowBookCount}");
                            }

                            // c.	else show “Insufficient balance. Please rechange and proceed”. 
                            else
                            {
                                System.Console.WriteLine("Insufficient balance. Please rechange and proceed");
                            }
                        }
                    }

                }
            }

            // 5.	Else, change the Status in Booking History to “Returned” and show Book returned successfully. Also, update the “BookCount”.



        }
        public static void WalletRecharge()
        {

            //             1.	Ask the customer whether he wish to recharge the wallet. 


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

