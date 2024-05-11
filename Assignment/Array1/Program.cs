using System;
using System.Xml.Schema;
namespace Array1
{
    class Program 
    {
        public static void Main(string[] args)
        {
            
              // int i;
              // int flag=1;
              // int n=int.Parse(Console.ReadLine());
              // int k=int.Parse(Console.ReadLine());
              // int[] arr=new int[n];
              // for(i=0;i<n;i++)
              // {
              //   arr[i]=int.Parse(Console.ReadLine());
              // }
              // for(i=0;i<n;i++)
              // {
              //   if (arr[i]==k)
              //   {
              //       flag=0;
              //       Console.WriteLine(i);
                    
              //   }
               
              // }
              // if(flag==1)
              // {
              //   Console.WriteLine("-1");
              // }
          

            // int i,count=0;
            // int flag=1;
            //     int n=int.Parse(Console.ReadLine());
            //     string word=Console.ReadLine();
            //     int k=int.Parse(Console.ReadLine());
            //     string[] word2=word.Split(',');
            //     int[] val=new int[n];
            //     for( i=0 ;i<n;i++)
            //     {
            //         val[i]=int.Parse(word2[i]);
         
            //     }
            //     for(i=0;i<n;i++)
            //     {
            //         if (val[i]==k)
            //         {   flag=0;
            //              count=count+1;
                         
            //         }
                   

            //     }
            //     if(flag==0)
            //     {
            //          Console.WriteLine("yes "+count);
            //     }
            //     else{
            //         Console.WriteLine("no");
            //     }
               
                // double salary=double.Parse(Console.ReadLine());
                // double month=double.Parse(Console.ReadLine());
                // int year=int.Parse(Console.ReadLine());
                // double leave=double.Parse(Console.ReadLine());
                // double perday;
                // double remday;
                // //double total;
                // if(month==1 || month==3 || month==5 || month== 7|| month== 8|| month==10 || month==12)
                // {
                //     perday=salary/31;
                //     remday=31-leave;
                //     //total=perday*remday;
                //     Console.WriteLine("Take-Home Salary: "+(Math.Round(perday*remday,2)));
                    
                // }
                // else if(month==2)
                // {
                //     perday=salary/28;
                //     remday=28-leave;
                //     Console.WriteLine("Take-Home-Salary: "+(Math.Round(perday*remday,2)));
                // }
                // else
                // {
                //     perday=salary/30;
                //     remday=30-leave;
                //     Console.WriteLine("Take-Home-Salary: "+(Math.Round(perday*remday,2)));
                // }


                // DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                // if (date.Month>=12)
                // {
                //     Console.WriteLine("no");
                // }


            //      int i,j,k;
            //    int row=int.Parse(Console.ReadLine());
            //    int col=int.Parse(Console.ReadLine());
            //    int[,] arr=new int[row,col];
            //    int[,] arr1=new int[row,col];
            //    int[,] arr2=new int[row,col];
            //    for(i=0;i<row;i++)
            //    {
            //     for(j=0;j<col;j++)
            //     {
            //         arr[i,j]=int.Parse(Console.ReadLine());

            //     }
            //     }
            //      for(i=0;i<row;i++)
            //    {
            //     for(j=0;j<col;j++)
            //     {
            //         arr1[i,j]=int.Parse(Console.ReadLine());

            //     }
            //    }
            //    for(i=0;i<row;i++)
            //    {
            //     for(j=0;j<col;j++)
            //    {
            //     arr2[i,j]=0;
            //     for(k=0;k<row;k++)
            //     {
            //        arr2[i,j]+=(arr[i,k]*arr1[k,j]);
                  
            //     }
            //     Console.WriteLine();
            //    }
            //    }

            //     for(i=0;i<row;i++)
            //    {
            //     for(j=0;j<col;j++)
            //    {
            //      Console.Write(arr2[i,j]+" ");
            //     }
            //     Console.WriteLine();
            //    }

            // int N=int.Parse(Console.ReadLine());
            //   double W=double.Parse(Console.ReadLine());
            //   double L=double.Parse(Console.ReadLine());
            //   int M=int.Parse(Console.ReadLine());
            //   int O=int.Parse(Console.ReadLine());

            //   double area=N*N;
            //   double AreaBeanch=M*O;
            //   double area_cover=area-O;
            //   //double area_rect=W*L;
            //   double need_tiles=area_cover/(W*L);
            //   double time=need_tiles*0.2;
            //   Console.WriteLine((need_tiles));
            //   Console.WriteLine(Math.Round(time));

            
            // string dateString = "???";
//             string format = "ddd dd MMM h:mm tt yyyy";
//             DateTime dateTime;
//             if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture,DateTimeStyles.None, out dateTime))
//              {
//               Console.WriteLine(dateTime);
//                 }
//           else
//              {
//              Console.WriteLine("Not a date");
//          }


                // string date=Console.ReadLine();
                // DateTime dat;
                // if(DateTime.TryParseExact(date,"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out dat))
                // {
                    
                //     Console.WriteLine("yes");
                // }
                // else
                // {
                //     Console.WriteLine("no");
                // }

                // DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                // int n=int.Parse(Console.ReadLine());
                // int flag=1;
                // DateTime[] date2=new DateTime[n];

                //   for(int i=0;i<n;i++)
                // {
                //     date2[i]=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

                // }
                //  if(((date1.DayOfWeek).ToString()=="Saturday") || ((date1.DayOfWeek).ToString()=="Sunday"))
                // {
                //     flag=0;
                //     //Console.WriteLine("holyday");
                // }
                // else
                // {
                    
                
                    
                
                // for(int i=0;i<n;i++)
                // {
                //    // Console.WriteLine(date2[i]);
                //     if(date2[i]==date1)
                //     {
                //         flag=0;
                //     }
                // }
                // }
                // if(flag==0)
                // {
                //     Console.WriteLine("holyday");
                // }
                
               
                // else{
                //     Console.WriteLine("not");
                // }
              

              int row=int.Parse(Console.ReadLine());
                int col=int.Parse(Console.ReadLine());
                for(int i=0;i<row-1;i++)
                {
                    for(int j=0;j<col-1;j++)
                    {
                        if (i>0 && i<row-1 && j>0 && j<=col-1)
                        {
                              Console.Write(" ");
                        }
                        else{
                            Console.Write("*");
                        }
                      
                    }
                    Console.WriteLine();
                }
               






              

        }
    }
}