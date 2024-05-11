using System;
namespace Single2;
class Program 
{
    public static void Main(string[] args)
    {
        AccountDetails accountDetails=new AccountDetails("gnanam","Sekar",98765,"jfsdkjf",new DateTime(2001,07,28),"male",98765,"Mkm",8767,500);

        System.Console.WriteLine(accountDetails.ShowInfo());
       
        System.Console.WriteLine(accountDetails.Withrown(200));
        System.Console.WriteLine(accountDetails.Deposite(10000));
         System.Console.WriteLine(accountDetails.ShowBalance());
    }
}
