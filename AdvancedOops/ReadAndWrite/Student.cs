using System;
using System.Collections.Generic;
namespace ReadAndWrite
{
    public enum Gender {select, Male, Female}
    public class Student
    {
        public string Name { get; set; }
        public string Fathername { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public int Mark { get; set; }

   
    }
}
