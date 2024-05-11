using System;
using System.IO;
namespace Filefolder;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\GnanaprakasamSekar\OneDrive - Syncfusion\Desktop\Myfolder";
        string folderPath = path + "/Gnanam";
        if (!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Creating folder..");
            Directory.CreateDirectory(folderPath);

        }
        else
        {
            System.Console.WriteLine("folder already exisits");
        }

        string filePath = path + "/myfile.txt";
        if (!File.Exists(filePath))
        {
            System.Console.WriteLine("creating file...");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("Already exist");
        }
        bool flag=true;
        do
        {
            

            System.Console.WriteLine("1.Create folder 2. create file 3.Delete Folder 4.deletefile 5.Exit");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        System.Console.WriteLine("Enter folder name:");
                        string folder = Console.ReadLine();
                        string newpath = path + "/" + folder;
                        if (!Directory.Exists(newpath))
                        {
                            System.Console.WriteLine("Creating folder..");
                            Directory.CreateDirectory(newpath);
                        }
                        else
                        {
                            System.Console.WriteLine("folder already exisits");
                        }
                        break;
                    }
                case 2:
                    {
                        System.Console.WriteLine("Enter File name:");
                        string fileName = Console.ReadLine();
                        System.Console.WriteLine("Entr file Extension");
                        string extension = Console.ReadLine();
                        string newFilePath = path + "/" + fileName + "." + extension;

                        if (!File.Exists(newFilePath))
                        {
                            System.Console.WriteLine("creating file..." + fileName + "." + extension);
                            File.Create(newFilePath);
                        }
                        else
                        {
                            System.Console.WriteLine("Already exist");
                        }

                        break;
                    }
                case 3:
                    {
                        foreach (string path1 in Directory.GetDirectories(path))
                        {
                            System.Console.WriteLine(path1);
                        }
                        System.Console.WriteLine("Select the folder you with to remove:");
                        string folder1 = Console.ReadLine();
                        // bool flag=true;
                        foreach (string path1 in Directory.GetDirectories(path))
                        {
                            if (path1.Contains(folder1))
                            {
                                // flag=false;

                                Directory.Delete(path1);

                            }

                        }
                        break;

                    }
                case 4:
                    {
                        foreach (string file1 in Directory.GetFiles(path))
                        {
                            System.Console.WriteLine(file1);
                        }
                        System.Console.WriteLine("Select the file you with to remove:");
                        string file2 = Console.ReadLine();
                        //bool flag=true;
                        foreach (string file1 in Directory.GetFiles(path))
                        {
                            if (file1.Contains(file2))
                            {
                                // flag=false;

                                Directory.Delete(file1);
                            }

                        }


                        break;
                    }
            }
        }while(flag);

    }
}
