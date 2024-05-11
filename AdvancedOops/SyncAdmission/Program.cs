using System;
using System.Collections.Generic;
namespace SyncAdmission;
class Program
{
    public static void Main(string[] args)
    {
        FileHandlinng.Create();
      // Operation.AddDefaultData();  

       FileHandlinng.ReadFormCsv();
        Operation.MainMenu();
        FileHandlinng.WriteToCsv();
        
        
       
    }
}
