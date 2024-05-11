using System;
using System.Collections.Concurrent;
using System.IO.Pipes;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
namespace Bubble
{
    class Program
    {
        // public static void Main(string[] args)
        // {
        //     int[] val = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };

        //     QuickSort(val,0,val.Length-1);
        //     for(int i=0;i<val.Length-1;i++)
        //     {
        //         System.Console.Write(val[i]+",");
        //     }



        // }
        // public static void QuickSort(int[] val, int start, int end)
        // {
        //     if (start < end)
        //     {
        //         int pivot = Partition(val, start, end);
        //         {
                    
                    
        //                 QuickSort(val, start, pivot - 1);
                    
        //                 QuickSort(val, pivot + 1, end);
                   
        //         }

        //     }
        // }
        // public static int Partition(int[] val, int start, int end)
        // {
        //     int pivot = val[end];

        //     int i=start-1;
        //     for(int j=start;j<=end;j++)
        //     {
        //         if(val[j]<pivot)
        //         {
        //             i++;
        //             int temp1=val[i];
        //             val[i]=val[j];
        //             val[j]=temp1;

        //         }
        //     }
        //     int temp=val[i+1];
        //     val[i+1]=val[end];
        //     val[end]=temp;
        //     return i+1;

          
        // }



        //    public static void Main(string[] args)
        // {
        //     char[] val = { 	'c','a','f','b','k','h','z','t','m','p','l','d'};

        //     QuickSort(val,0,val.Length-1);
        //     for(int i=0;i<val.Length-1;i++)
        //     {
        //         System.Console.Write(val[i]+",");
        //     }



        // }
        // public static void QuickSort(char[] val, int start, int end)
        // {
        //     if (start < end)
        //     {
        //         int pivot = Partition(val, start, end);
        //         {
                    
                    
        //                 QuickSort(val, start, pivot - 1);
                    
        //                 QuickSort(val, pivot + 1, end);
                   
        //         }

        //     }
        // }
        // public static int Partition(char[] val, int start, int end)
        // {
        //     int pivot = val[end];

        //     int i=start-1;
        //     for(int j=start;j<=end;j++)
        //     {
        //         if(val[j]<pivot)
        //         {
        //             i++;
        //             char temp1=val[i];
        //             val[i]=val[j];
        //             val[j]=temp1;

        //         }
        //     }
        //     char temp=val[i+1];
        //     val[i+1]=val[end];
        //     val[end]=temp;
        //     return i+1;

          
        // }

           public static void Main(string[] args)
        {
            string[] val = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};

            QuickSort(val,0,val.Length-1);
            for(int i=0;i<val.Length-1;i++)
            {
                System.Console.Write(val[i]+",");
            }



        }
        public static void QuickSort(string[] val, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(val, start, end);
                {
                    
                    
                        QuickSort(val, start, pivot - 1);
                    
                        QuickSort(val, pivot + 1, end);
                   
                }

            }
        }
        public static int Partition(string[] val, int start, int end)
        {
            string pivot = val[end];

            int i=start-1;
            for(int j=start;j<=end;j++)
            {
                int result=val[j].CompareTo(pivot);
                if(result<0)
                {
                    i++;
                    string temp1=val[i];
                    val[i]=val[j];
                    val[j]=temp1;

                }
            }
            string temp=val[i+1];
            val[i+1]=val[end];
            val[end]=temp;
            return i+1;

          
        }
    }
}



