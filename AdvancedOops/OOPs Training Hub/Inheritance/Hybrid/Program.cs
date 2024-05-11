using System;
namespace Hybrid;
class Program 
{
    public static void Main(string[] args)
    {
        MarkSheet markSheet=new MarkSheet("jfdhs","fdkhs",88567,"hsfdak",new DateTime(2022,09,08),"male", 98,87,45,"M101","12/04/2024",783,45.5);
        System.Console.WriteLine(markSheet.ShowDetails());
    }
}
