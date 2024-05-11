using System;
namespace Bubble
{
    class Program
    {
        public static void Main(string[] args)
        {
            //     int[] val = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };

            //     //System.Console.WriteLine("before:" + val);
            //     // BubbleSort();

            //     //  }
            //     //public void BubbleSort( int[] val)

            //     // {
            //     int n = val.Length;
            //     for (int i = 0; i < n - 1; i++)
            //     {
            //         for (int j = 0; j < n - i - 1; j++)
            //         {
            //             if (val[j] > val[j + 1])
            //             {
            //                 int temp = val[j];
            //                 val[j] = val[j + 1];
            //                 val[j + 1] = temp;
            //             }
            //         }
            //     }
            //     for(int i=0;i<n-1;i++)
            //     {
            //         System.Console.Write(val[i]+",");
            //     }





            //char[] val = { 'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'  };


            //System.Console.WriteLine("before:" + val);
            // BubbleSort();

            //  }
            //public void BubbleSort( int[] val)

            // {
            // int n = val.Length;
            // // for(int i=0;i<n;i++)
            // // {
            // //     System.Console.Write(val[i]);
            // // }
            // for (int i = 0; i < n - 1; i++)
            // {
            //     for (int j = 0; j < n - i - 1; j++)
            //     {
            //         if (val[j] > val[j + 1])
            //         {
            //             char temp = val[j];
            //             val[j] = val[j + 1];
            //             val[j + 1] = temp;
            //         }
            //     }
            // }
            // for(int i=0;i<n-1;i++)
            // {
            //     System.Console.Write(val[i]+",");
            // }



            string[] val = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
            int n = val.Length;
            // for(int i=0;i<n;i++)
            // {
            //     System.Console.Write(val[i]);
            // }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                   int result= val[j].CompareTo(val[j + 1]);
                    if(result>0)
                   
                    {
                        string temp = val[j];
                        val[j] = val[j + 1];
                        val[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                System.Console.Write(val[i] + ",");
            }






        }


    }


}

