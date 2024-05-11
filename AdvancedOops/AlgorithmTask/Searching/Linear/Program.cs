using System;
namespace Linear
{
    class Program
    {
        public static void Main(string[] args)
        {
            //      int[] val = {45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77  };
            //     Array.Sort(val);
            //     int position = LinearSearch(val, 66);
            //     if (position > -1)
            //     {
            //         System.Console.WriteLine("Element is found:" + position);
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Element is not found:");
            //     }

            // }
            // static int LinearSearch(int []val, int searchElemnt)
            // {
            //     int position=-1;
            //     for(int i=0;i<val.Length-1;i++)
            //     {
            //         if(val[i]==searchElemnt)
            //         {
            //             position=i;
            //             break;
            //         }
            //     }
            //     return position;




            //  char[] letter = {'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'  };
            //     Array.Sort(letter);
            //     int position = LinearSearch(letter, 'm');
            //     if (position > -1)
            //     {
            //         System.Console.WriteLine("Element is found:" + position);
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Element is not found:");
            //     }

            // }
            // static int LinearSearch(char []letter, char searchElemnt)
            // {
            //     int position=-1;
            //     for(int i=0;i<letter.Length-1;i++)
            //     {
            //         if(letter[i]==searchElemnt)
            //         {
            //             position=i;
            //             break;
            //         }
            //     }
            //     return position;




            string[] word = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
            Array.Sort(word);
            int position = LinearSearch(word, "SF3067");
            if (position > -1)
            {
                System.Console.WriteLine("Element is found:" + position);
            }
            else
            {
                System.Console.WriteLine("Element is not found:");
            }

            static int LinearSearch(string[] letter, string searchElemnt)
            {
                int position = -1;
                for (int i = 0; i < letter.Length - 1; i++)
                {
                    if (letter[i] == searchElemnt)
                    {
                        position = i;
                        break;
                    }
                }
                return position;
            }


        }
    }
}