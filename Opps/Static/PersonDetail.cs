using System;

namespace Static
{
    // public class PersonDetail
    // {
    //     public string name { get; set; }
    //     public string FatherName { get; set; }

    // we create static element inside the nonstatic element
            //public static int tax{get;set;}
    // }

        public  static class PersonDetail
        {
            public static int A { get; set; }
            public static int B { get; set; }

            //Constructr

            static PersonDetail()
            {
                A=10;
                B=20;
            }

            //Static method

            public static int add()
            {
                int c=A+B;
                return c;
            }

        }

}
