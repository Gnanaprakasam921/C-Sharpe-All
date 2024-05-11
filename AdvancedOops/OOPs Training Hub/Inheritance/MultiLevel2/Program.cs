using System;
namespace MultiLevel2;
class Program 
{
    public static void Main(string[] args)
    {
        BookInfo bookInfo=new BookInfo("MCA","MCA",1,2,"kfdsjh","fdsjk",200);
        System.Console.WriteLine(bookInfo.DisplayInfo());
    }
}
