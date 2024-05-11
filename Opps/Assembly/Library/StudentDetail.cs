using System;

namespace Library
{
    public enum Gender{Select,Male,Femal}
    public class StudentDetail
    {
        
          //field 
            //   private string studentname;

            //   //properties
            //   public string Sudentname
            //   {
            //     get
            //     {
            //       return studentname;
            //     }
            //     set{
            //       studentname=value;
            //     }

            //   }

            // // auto property
            // public string Fathername{get;set;}
            public static int s_studentIdinfo=1000;

            public string studentID { get;  } // This is for auto increment (only get for prodtection user can't modify )
            
        public string studentname { get; set; }
        public string fathername { get; set; }
        public Gender gender { get; set; }  // Enum using 
        public DateTime dob { get; set; }
        public long phone { get; set; }
        public int tamil { get; set; }
        public int english { get; set; }
        public int maths { get; set; }


        // Constructor

        // 1/ Default Constructor

        public StudentDetail()
        {
         studentname="Enter your Name";
         fathername="Father Name";
         gender=Gender.Select;   // enum using 
        }

        //2.peramerised Constructor

        public StudentDetail (string Student_Name,string Father_Name, Gender _Gender, DateTime Dob, int Tamil, int English)

        {
            s_studentIdinfo++;  // increment the id
            studentID="SF"+s_studentIdinfo;


            studentname=Student_Name;
            fathername=Father_Name;
            gender=_Gender;
            dob=Dob;
           // phone=Phone;
            tamil=Tamil;
            english=English;
            //maths=Maths;




        }

        // Destructor

        ~StudentDetail()
        {
            Console.WriteLine("Destructor called");
        }


        //method 
        public bool check(double cutoff)
        {
            double avg=(tamil+english)/2;
            if(avg>=cutoff)
            {
                return true;

            }
            else{
                return false;
            }
    }

    }
}   
