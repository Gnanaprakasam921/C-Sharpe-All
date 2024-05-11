using System;
using System.Collections.Generic;
namespace Abstract 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            //Salary salary=new Salary() // cant create class

            Syncfusion syncfusion=new Syncfusion("SF1001","Gnanam","Syncfusion");
            TCS tCS=new TCS("Tcs1001","PS","TCS");
            List<Salary> salaries=new List<Salary>();
            salaries.Add(syncfusion);
            salaries.Add(tCS);
        }
    }
}
