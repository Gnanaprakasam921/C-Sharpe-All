using System;
using System.IO;
namespace Metro 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            FileFolder.ReadCsv();
            FileFolder.Create();
            
            //Operation.AddDefaultData();
            Operation.MainMenu();
           FileFolder.WriteCsv();
        }
    }
}