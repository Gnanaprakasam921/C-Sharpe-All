using System;
using System.Globalization;
namespace Set2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // double r=int.Parse(Console.ReadLine());
            // //double pi=2/7;

            // if(r<0)
            // {
            //     Console.WriteLine("ERROR");
            // }
            // else{


            // double circum=2*Math.PI*r;
            // Console.WriteLine(Math.Round(circum,2));
            //   }


            // Question 2


            //    int n=int.Parse(Console.ReadLine());
            //     //int flag=1;
            //    string s=Console.ReadLine();
            //    string[] str=s.Split(",");
            //    int[] val=new int[n];
            //    //int i,j;
            //    for(int i=0;i<n;i++)
            //    {
            //     val[i]=int.Parse(str[i]);
            //    }

            //     if(n==1)
            //     {
            //         Console.WriteLine(" Dealer 0");
            //     }
            //     else
            //     {
            //         int ind=0;
            //         foreach(int i in val)
            //         {
            //             if(i>=15000)
            //             {
            //                 ind++;
            //             }
            //         }
            //         Console.WriteLine($"Dealer {ind}");
            //     }



            //    }


            // //Question 3

            //  int n=int.Parse(Console.ReadLine());
            //     int sum=0;
            //    string s=Console.ReadLine();
            //    string[] str=s.Split(",");
            //    int[] val=new int[n];
            //    int i;
            //    for(i=0;i<n;i++)
            //    {
            //     val[i]=int.Parse(str[i]);
            //    }
            //    for(i=0;i<n;i++)
            //    {
            //     sum=sum+val[i];
            //    }

            //    if(sum%3==0 && sum%5==0 && sum%2==0)
            //    {
            //     Console.WriteLine("1");
            //    }
            //    else
            //    {
            //     Console.WriteLine("0");
            //    }

            //  char c=char.Parse(Console.ReadLine());
            // for(int i='A';i<='Z';i++)
            // {
            //     for(int j=i;j<=c-1;j++)
            //     {
            //         Console.Write(" ");
            //     }
            //     for(int k='A';k<=2*i-1;k++)
            //     {
            //         Console.Write(k-'0');
            //     }
            //     Console.WriteLine();
            // }



            //  int n=int.Parse(Console.ReadLine());
            //     string s=Console.ReadLine();
            //     string[] str=s.Split(",");
            //     string s1=Console.ReadLine();
            //     //int val3;
            //     int flag=1;
            //     int i,j;
            //     string[] str1=s1.Split(",");
            //     int[] val1=new int[n];
            //     for( i=0;i<n;i++)
            //     {
            //         val1[i]=int.Parse(str[i]);
            //     }
            //     int[] val2=new int[n];
            //     for( j=0;j<n;j++)
            //     {
            //         val2[j]=int.Parse(str1[j]);
            //     }

            //     int[] val3=new int[10];

            //     for( i=0;i<n;i++)
            //     {
            //         for( j=0;j<n;j++)
            //         {
            //          if(val1[i]==val2[j])
            //          {
            //          val3[i]=val1[i];

            //          }
            //      }
            //          //break;

            //         }
            //         for( i=0;i<n;i++)
            //         {
            //             for( j=i+1;j<n;j++)
            //             {
            //                 if(val3[i]==val3[j])

            //                 {
            //                     flag=0;
            //                     //Console.WriteLine(val3[i]);
            //                 }

            //             }
            //         }
            //         if(flag==0)
            //         {
            //             Console.WriteLine(val1[i]);
            //         }





            //     int n =int.Parse(Console.ReadLine());
            // string[] str=new string[]{"","A","C","E","G","I","L","N"};
            // for(int i=1;i<=n;i++)
            // {
            //     for(int j=i;j<=n-1;j++)
            //     {
            //         Console.Write(" ");
            //     }
            //     for(int k=1;k<=2*i-1; k++)
            //     {
            //         Console.Write(str[i]);
            //     }
            //     Console.WriteLine();
            // }

            // }


            // Simple C# program to remove
            // duplicates
            //using System;

            //class GFG {

            // Function to remove duplicate
            // elements This function returns
            // new size of modified array.
            static int removeDuplicates(int[] arr, int n)
            {

                // Return, if array is empty
                // or contains a single element
                if (n == 0 || n == 1)
                    return n;

                int[] temp = new int[n];

                // Start traversing elements
                int j = 0;

                for (int i = 0; i < n - 1; i++)

                    // If current element is not equal
                    // to next element then store that
                    // current element
                    if (arr[i] != arr[i + 1])
                        temp[j++] = arr[i];

                // Store the last element as
                // whether it is unique or 
                // repeated, it hasn't
                // stored previously
                temp[j++] = arr[n - 1];

                // Modify original array
                for (int i = 0; i < j; i++)
                    arr[i] = temp[i];

                return j;
            }

            // Driver code
            //public static void Main () 
            {
                //int []arr = {1, 2, 2, 3, 4, 4, 4, 5, 5};
                //int n = arr.Length;
                int n = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                string[] str = s.Split(",");
                int[] val = new int[n];
                int i;
                for (i = 0; i < n; i++)
                {
                    val[i] = int.Parse(str[i]);
                }


                //n = removeDuplicates(arr, n);

                // Print updated array
                for (int i = 0; i < n; i++)
                    Console.Write(val[i] + " ");
            }
        }

        // This code is contributed by nitin mittal.







    }

}


