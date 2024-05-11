using System;
using Hybrid1;
namespace Hybrid;
class Program 
{
    public static void Main(string[] args)
    {
        SavingAccount savingAccount=new SavingAccount("fjshd","male",new DateTime(2021,11,12),9876,"fshdk","fdsh","khfsdj",9876,"Savings","iob","chennai",10000);

        savingAccount.Deposite(1000);
        savingAccount.Withdrawn(500);
        System.Console.WriteLine(savingAccount.BalanceCheck());
    }
}
