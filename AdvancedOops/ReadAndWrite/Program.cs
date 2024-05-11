using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.Win32.SafeHandles;
namespace ReadAndWrite;
class Program
{
    public static void Main(string[] args)
    {
        if (!Directory.Exists("TestFolder"))
        {
            System.Console.WriteLine("Create folder");
            Directory.CreateDirectory("TestFolder");

        }
        else
        {
            System.Console.WriteLine("Already Exists..");
        }
        if (!File.Exists("TestFolder/Data.csv"))
        {
            System.Console.WriteLine("Create csv file");
            File.Create("TestFolder/Data.csv").Close();


        }
        else
        {
            System.Console.WriteLine("csv already exist");

        }
        if (!File.Exists("TestFolder/Data1.json"))
        {
            System.Console.WriteLine("Json file created");
            File.Create("TestFolder/Data1.json").Close();
        }
        else
        {
            System.Console.WriteLine("Already exist..");
        }

        List<Student> studentList = new List<Student>();
        studentList.Add(new Student() { Name = "Gnanam", Fathername = "Sekar", Gender = Gender.Male, DOB = new DateTime(2001, 11, 26), Mark = 443 });
        studentList.Add(new Student() { Name = "Gokul", Fathername = "Rave", Gender = Gender.Male, DOB = new DateTime(2001, 11, 20), Mark = 480 });
        studentList.Add(new Student() { Name = "lefin", Fathername = "Albart", Gender = Gender.Male, DOB = new DateTime(2001, 11, 29), Mark = 443 });


        writeToCsV(studentList);
        ReadCsv();
         WriteJson(studentList);
        ReadJson();
    

    }

        static void writeToCsV(List<Student> studentList)
        {
            StreamWriter sw = new StreamWriter("TestFolder/Data.csv");
            foreach (Student student in studentList)
            {
                string line = student.Name + "," + student.Fathername + "," + student.Gender + "," + student.DOB.ToString("dd/MM/yyyy") + "," + student.Mark;

                sw.WriteLine(line);
            }
            sw.Close();
        }
        static void ReadCsv()
        {
            List<Student> newList = new List<Student>();
            StreamReader sr = new StreamReader("TestFolder/Data.csv");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] value = line.Split(",");
                if (value[0] != "")
                {
                    Student student = new Student()
                    {
                        Name = value[0],
                        Fathername = value[1],
                        Gender = Enum.Parse<Gender>(value[2]),
                        DOB = DateTime.ParseExact(value[3], "dd/MM/yyyy", null),
                        Mark = int.Parse(value[4])


                    };
                    newList.Add(student);
                }
                line = sr.ReadLine();

            }
            sr.Close();
            foreach (Student student in newList)
            {
                System.Console.WriteLine($"Name:{student.Name}Father:{student.Fathername}Gender:{student.Gender}DOB:{student.DOB.ToString("dd/MM/yyyy")}Mark:{student.Mark}");
                //System.Console.WriteLine("Gender"+student.Gender+"DOB"+student.DOB+"Mark:"+student.DOB);
            }
        }

        static void WriteJson(List<Student> studentList)

        {
            StreamWriter sw = new StreamWriter("TestFolder/Data1.json");
            var option = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonData = JsonSerializer.Serialize(studentList, option);
            sw.WriteLine(jsonData);
            sw.Close();

        }


        static void ReadJson()
        {
            StreamReader sr = new StreamReader("TestFolder/Data1.json");
            List<Student> students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("TestFolder/Data1.json"));
            foreach (Student student in students)
            {
                System.Console.WriteLine($"Name:{student.Name}Father:{student.Fathername}Gender:{student.Gender}DOB:{student.DOB.ToString("dd/MM/yyyy")}Mark:{student.Mark}");
                // System.Console.WriteLine();
            }
        }


    
}
