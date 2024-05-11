using System;
namespace CustomDict;
class Program 
{
    public static void Main(string[] args)
    {
        CustomDictonary<string, string> myDictionary=new CustomDictonary<string,string>();
        myDictionary.Add("SF3001","Gnanam");
        myDictionary.Add("SF3002","Golil");
        myDictionary.Add("SF3002","Mani");

        foreach(KeyValue<string,string> data in myDictionary)
        {
            System.Console.WriteLine("key:"+data.Key +"  "+"value"+data.Value);
        }

        // Set property

         myDictionary["SF3001"]="Suresh";

         
        // it use we create indexer
        string name=myDictionary["SF3001"];
        System.Console.WriteLine("Name is:"+name);
       
    }
}
