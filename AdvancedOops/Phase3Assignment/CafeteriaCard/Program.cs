using System;
namespace CafeteriaCard
{
    class Program 
    {
        public static void Main(string[] args)
        {
             FileFolder.Create();
           // Operation.AddDefaultData();
            FileFolder.ReadCsv();
            Operation.MainMenu();
            FileFolder.WriteCsv();
            
        }
    }
}
