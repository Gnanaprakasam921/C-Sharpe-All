﻿using System;
namespace Selection
{
    class Program
    {
        public static void Main(string[] args)
        {
                // int[] val = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };

                // //System.Console.WriteLine("before:" + val);
                // // BubbleSort();

                // //  }
                // //public void BubbleSort( int[] val)

                // // {
                // int n = val.Length;
                // for (int i = 0; i < n - 1; i++)
                // {
                //     int temp=i;
                //     for (int j = i+1; j < n; j++)
                //     {
                //         if (val[j] < val[temp])
                //         {
                //            temp=j;  //lowest number.
                //         }
                //     }
                //     int low=val[temp];
                //     val[temp]=val[i];
                //     val[i]=low;
                // }
                
                // for(int i=0;i<n-1;i++)
                // {
                //     System.Console.Write(val[i]+",");
                // }



                // char[] val = { 'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d' };

               
                // int n = val.Length;
                // for (int i = 0; i < n - 1; i++)
                // {
                //     int temp=i;
                //     for (int j = i+1; j < n; j++)
                //     {
                //         if (val[j] < val[temp])
                //         {
                //            temp=j;  //lowest number.
                //         }
                //     }
                //     char low=val[temp];
                //     val[temp]=val[i];
                //     val[i]=low;
                // }
                
                // for(int i=0;i<n-1;i++)
                // {
                //     System.Console.Write(val[i]+",");
                // }



                string[] val = {  "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };

                //System.Console.WriteLine("before:" + val);
                // BubbleSort();

                //  }
                //public void BubbleSort( int[] val)

                // {
                int n = val.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    int temp=i;
                    for (int j = i+1; j < n; j++)
                    {
                        int result=val[j].CompareTo (val[temp]);
                        if(result<0)
                        {
                           temp=j;  //lowest number.
                        }
                    }
                    string low=val[temp];
                    val[temp]=val[i];
                    val[i]=low;
                }
                
                for(int i=0;i<n-1;i++)
                {
                    System.Console.Write(val[i]+",");
                }
        }
    }
}


