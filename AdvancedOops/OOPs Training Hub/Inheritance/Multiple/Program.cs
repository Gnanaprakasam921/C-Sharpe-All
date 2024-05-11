using System;
namespace Multiple;
class Program 
{
    public static void Main(string[] args)
    {
        RegiserPerson regiserPerson=new RegiserPerson("Gnanam","Male",new DateTime(2001,07,28),987654,Marital.Single,"sekar","Kalyani","Pudukudi", 2,DateTime.Now);
        System.Console.WriteLine(regiserPerson.ShowDetails());
        System.Console.WriteLine();

        PersonalDetails personalDetails=new RegiserPerson("Gnanam","Male",new DateTime(2001,07,28),987654,Marital.Single,"sekar","Kalyani","Pudukudi", 2,DateTime.Now);
        System.Console.WriteLine(personalDetails.ShowDetails());
        
    }
}
