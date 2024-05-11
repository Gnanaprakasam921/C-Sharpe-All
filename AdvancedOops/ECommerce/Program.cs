using System;
using ECommerce;
namespace  ECommerece
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileHandling.Create();
            //Operation.AddDefaultData();
            FileHandling.ReadCsv();
            Operation.MainMenu();
            FileHandling.WriteCsv();
            
        }
    }
}