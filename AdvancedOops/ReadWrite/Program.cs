using System;
using System.IO;
namespace ReadWrite;
class Program 
{


    public static void Main(string[] args)
    {
       if(!Directory.Exists("TestFolder"))
       // for creating folder oustide the folder 
       //if(Directory.Exists("../TestFolder"))

       {
        System.Console.WriteLine("Createing folder");
        Directory.CreateDirectory("TestFolder");
        //Directory.CreateDirectory("../TestFolder");

        //create folder in desktop
       // Directory.CreateDirectory("../..TestFolder");

       }
       else{
        System.Console.WriteLine("Already exisits:");
       }
    
        if(!File.Exists("TestFolder/Myfile.txt"))
        {
            System.Console.WriteLine("Creating file");
            File.Create("TestFolder/MyFile.txt");
        }
        else
        {
            System.Console.WriteLine("Already exist");
        }
        System.Console.WriteLine("1.Read 2.Write");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                StreamReader sr= new StreamReader("TestFolder/MyFile.txt");
                string data= sr.ReadLine();
                while(data!=null)   // give the contenet form the text file
                {
                    System.Console.WriteLine(data);
                    data=sr.ReadLine();
                }
                sr.Close();
                break;
            }
            case 2:
            {
                // strore the all content to the array
                string[] content=File.ReadAllLines("TestFolder/Myfile.txt");
                StreamWriter sw=new StreamWriter("TestFolder/MyFile.txt");

                System.Console.WriteLine("Enter what do you want to palace in file");
                string data=Console.ReadLine();
                string old="";
                foreach(string line in content)
                {
                    old=old+line+"\n";

                }
                old=old+data+"\n";
                sw.WriteLine(old);
                sw.Close();

                


                break;
            }
        }
        

    }
}