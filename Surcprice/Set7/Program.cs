using System;
using System.Linq;
namespace Set7
{
    class Program

    {
        public static void Main(string[] args)
        {
            // string space="";
            // string s=Console.ReadLine();
            // string str;
            // for(int i=0;i<s.Length-1;i++)
            // {
            //     if (s[i]>97)
            //     {
            //         str=s[i]-97;
            //     }
            // }
            //Console.WriteLine(s.);

            //

            //}

            // int n=int.Parse(Console.ReadLine());
            // int count=1;
            //  for(int i=1;i<=n;i++)

            //  {
            //     for(int j=1;j<=i;j++)
            //     {
            //         Console.Write(count+" ");
            //         count++;

            //     }
            //     Console.WriteLine();
            //  }


            // string s=Console.ReadLine();
            // // //char[] str=s.ToCharArray();
            // // Console.WriteLine(s.);
            // string sp="";
            // string[] str=s.Split(" ");
            // for(int i=0;i<str.Length;i++)
            // {
            //     if(i%2==0)
            //     {
            //           sp=sp+" "+str[i].ToUpper();
            //         //Console.Write(str[i].ToUpper()+" ");
            //     }
            //     else
            //     {
            //         sp=sp+" "+str[i];
            //         //Console.Write((str[i])+" ");
            //     }
            // }
            // Console.WriteLine(sp.Trim());



            /// Set Seven 5th Question  
            /// 
            /// 
            //string sp="";
            //   int n=int.Parse(Console.ReadLine());
            //   string s=Console.ReadLine();
            //   string[] str=s.Split(" ");
            //   int[] val=new int[n];
            //   int temp;
            //   int i,j;
            //   for( i=0;i<n;i++)
            //   {
            //     val[i]=int.Parse(str[i]);
            //   }
            //   for( i=0;i<n;i++)
            //   {
            //     for( j=i+1;j<n;j++)
            //     {

            //         if(val[i]>val[j])
            //         {
            //             temp=val[i];
            //             val[i]=val[j];
            //             val[j]=temp;
            //         }

            //     }
            //     }
            //     //int[] val1=new int[50];
            //     int[] val2=val.Distinct().ToArray();
            //     //Console.WriteLine(val2);
            //     for(i=0;i<n;i++)
            //     {
            //         Console.Write(val2[i]);
            //     }

            //   }




            // for(int i=0;i<n;i++)
            // {
            //     sp+= (val[i] + " ");
            // }
            // Console.WriteLine(sp.Trim());
            //Console.WriteLine(sp[]);

            // string s=Console.ReadLine();
            // string[] str=s.Split(" ");
            // int ln=str.Length;
            // for(int i=0;i<ln;i++)
            // {

            // }

            //     string s=Console.ReadLine();
            //     string sp="";
            //     string str;

            //    //foreach(char i in s)
            //    for(int i=0;i<s.Length;i++)

            //    {
            //     if(s[i]>='A'&& s[i]<='Z')
            //     {
            //         str=s[i].ToString();
            //         sp=sp+str.ToLower();
            //         //Console.Write(s[i].ToUpper());
            //     }
            //     else{
            //         //Console.Write(s[i]-'A');

            //          str=s[i].ToString();
            //         sp=sp+str.ToUpper();
            //     }
            //    }
            //    Console.WriteLine(sp.Trim());



            // set 3 Question 5

            //     string s=Console.ReadLine();
            //    int[] arr= new int[60];
            //    for(int i=0;i<s.Length;i++)
            //    {
            //     if(s[i] !=' ')

            //         arr[s[i]-'A']++;

            //     }
            //     for(int i=0;i<s.Length;i++)
            //     {
            //         if(s[i]!=' ' && arr[s[i]-'A']>=2)
            //         {
            //             Console.Write(char.ToUpper(s[i]));
            //         }
            //         else
            //         {
            //             Console.Write(s[i]);
            //         }

            //     }


            // set 3question 6.

            //     string s=Console.ReadLine();
            //     string[] arr=s.Split(" ");
            //     string arr1;
            //    // string arr2="";
            //     for(int i=0;i<arr.Length;i++)
            //     {
            //        if(i==0 || i==(arr.Length-1))
            //        {
            //         Console.Write(arr[i]);
            //        }
            //        else{
            //             arr1=arr[i];
            //             for(int j=0;j<arr1.Length;j++)
            //             {
            //                 Console.Write(arr1[arr1.Length-j-1]);
            //             }
            //        }
            //        if(i!=arr.Length-1)
            //        {
            //         Console.Write(" ");
            //        }
            //     }






            //}



            int n = int.Parse(Console.ReadLine());
            int space = n - 1;
            // for (int i = 0; i < n; i++)
            // {
            //     string s = "";
            //     for (int j = 0; j < n - i - 1; j++)
            //     {
            //         s = s + " ";
            //     }
            //     for (int k = 0; k <= i; k++)
            //     {
            //         s = s + "* ";
            //     }
            //     Console.WriteLine(s.TrimEnd());

            // }
            space = n - 1;

            for (int l = n - 2; l >= n; l--)
            {
                string s = "";
                for (int m = 0; m < n - l - 1; m++)
                {
                    s = s + " ";
                }
                for (int o = 0; o <= l; o++)
                {
                    s = s + "* ";
                }
                Console.WriteLine(s.TrimEnd());

            }



            
            //   int n=int.Parse(Console.ReadLine());
            //   int i,j,k;
            //   for(i=1;i<=n;i++)
            //   {
            //     for(j=1;j<=n-i;j++)
            //     {
            //     Console.Write(" ");
                
            //     }
            //       for(k=1;k<=2*i-1;k++)
            //       {
            //         Console.Write("*");
            //       }
            //     Console.WriteLine();
            //   }


            // string s="";
            // string s1;
            //  string str=Console.ReadLine();
            //  int ln=str.Length-1;
            //  for(int i=ln;i>=0;i--)
            //  {
            //   s=s+str[i]; 
            //   //Console.Write(str[i]);
            //  }
            //  s1=s.ToUpper();
            //  Console.WriteLine(s1.Trim());
            

            //  string s1=Console.ReadLine();
            //  //char[] s=s1.ToCharArray();
            //  string[] str1=s1.Split(' ');
            //  string s2= Console.ReadLine();
            //  string[] str2=s2.Split(' ');
            // if((str1[str1.Length-1]).CompareTo(str2[str2.Length-1])<0)
            // {
            //   Console.WriteLine(s1);
            //   Console.WriteLine(s2);
            // }
            // else
            // {
            //   Console.WriteLine(s2);
            //   Console.WriteLine(s1);
            // }
        
         

        }
        
    }
}
