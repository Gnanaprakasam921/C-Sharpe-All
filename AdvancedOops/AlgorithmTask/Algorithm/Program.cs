using System;
namespace Algorithm
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Binary search
            //     int[] val={3,5,6,1,4,9};
            //     Array.Sort(val);
            //     int position=BinarySearch(val, 5);
            //     if(position>-1)
            //     {
            //         System.Console.WriteLine("Element is found:"+position);
            //     }
            //     else{
            //         System.Console.WriteLine("Element is not found:");
            //     }

            // }

            // static int BinarySearch(int[] val,int searchElement )

            // {
            //     int left=0, right=val.Length-1;
            //     while(left<=right)
            //     {
            //         int mid=left+((right-left)/2);
            //         if(val[mid]==searchElement)
            //         {
            //             return mid;
            //         }
            //         else if(val[mid]<searchElement)
            //         {
            //             left=mid+1;
            //         }
            //         else
            //         {
            //             right=mid-1;
            //         }
            //     }
            //     return -1;


            //liner search
            int[] val = { 3, 5, 6, 1, 4, 9 };
            Array.Sort(val);
            int position = LinearSearch(val, 5);
            if (position > -1)
            {
                System.Console.WriteLine("Element is found:" + position);
            }
            else
            {
                System.Console.WriteLine("Element is not found:");
            }

        }
        static int LinearSearch(int []val, int searchElemnt)
        {
            int position=-1;
            for(int i=0;i<val.Length-1;i++)
            {
                if(val[i]==searchElemnt)
                {
                    position=i;
                    break;
                }
            }
            return position;
        }

        // 


    }


} 

