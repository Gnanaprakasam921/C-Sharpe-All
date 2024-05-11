using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
namespace StrinManipulation
{
    class Program 
    {
        public static void Main(string[] args)
        {
            // int count=0;
            // Console.WriteLine("Enter the string:");
            // string name=Console.ReadLine();
            // Console.WriteLine("Enter the search string:");
            // string name2=Console.ReadLine();
            // int ln=name2.Length;
            // for (int i=0;i<name.Length-ln+1;i++)
            // {
            //  string newstring=name.Substring(i,ln);
            //  if(name2==newstring)
            //  {
            //     count++;
            //  }
             
            // }
            // Console.WriteLine(count);        
    
            // Console.WriteLine();
            



            // string str="Prem.Ganam.poo";
            // string [] s=str.Split('.');
            // foreach(string i in s)
            // { 
            //     Console.WriteLine(i+" ");
                
            // }

            // str.Substring

            

            // string a="gnanam";
            // for(int i=0;i<a.Length;i++)
            // {
            //     Console.WriteLine(a[2]);
            // }


             //int i;



              //string s;
              // string input=Console.ReadLine();
              // string[] splt=input.Split("");
              // string addstr=Console.ReadLine();
              // string srstr=Console.ReadLine();
              // for(int i=0; i < splt.Length; i++)
              // {
              //   if(splt[i] == srstr)
              //   {

              //       splt[i]=addstr+ " "+splt[i];
              //   }


              // }
              // foreach(string j in splt)
              // {
              //   Console.Write(j +" ");
              // }

            //     string s="";
            //  string str=Console.ReadLine();
            //  string str1=str.ToUpper();
            //    int ln=str.Length-1;
            //    for(int i=ln;i>=0;i--)
            //    {
            //     s=s+str[i];
            //    }
            //    Console.Write(s.ToUpper());


            // string input=Console.ReadLine();
            //   char[] splt=input.ToCharArray();
            //   string addstr=Console.ReadLine();
            //   string srstr=Console.ReadLine();
            //   char[] search=srstr.ToCharArray();
            //   for(int i=0; i < splt.Length; i++)
            //   {
            //     if(splt[i] == srstr[0])
            //     {

            //         splt[i]=addstr+ " "+splt[i];
            //         break;
            //     }


            //   }
            //   foreach(string j in splt)
            //   {
            //     Console.Write(j +" ");
            //   }
            


            //string s="";
               string input=Console.ReadLine();
              //string[] splt=input.Split(" ");
              string addstr=Console.ReadLine();
              string srstr=Console.ReadLine();
              int index=input.IndexOf(srstr);
              string all=input.Insert(index,addstr+" ");
              Console.WriteLine(all);
             
        }
    }
}
