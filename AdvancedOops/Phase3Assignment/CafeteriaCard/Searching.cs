using System;

namespace CafeteriaCard
{
    public class Searching
    {
        // public static void AddLogin()
        // {
        //     // 1.	Ask for the “UserID” of the user. Check the “UserID” in the user list. If it is not present show” Invalid UserID”. 



          public string UserID { get; set; }
 
        public static int BinarySearchLogin(CustomList<UserDetails> userList, string searchElement)
        {
            int start = 0; int end = userList.Count - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (userList[middle].UserID == searchElement)
                {
                    return middle;
                }
                else if (string.Compare(userList[middle].UserID, searchElement) < 0)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }
            return -1;
        }

        public static int BinarySearchGetProductID(CustomList<FoodDetails>foodList , string searchElement)
        {
            int start = 0; int end = foodList.Count - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (foodList[middle].FoodID == searchElement)
                {
                    return middle;
                }
                else if (string.Compare(foodList[middle].FoodID, searchElement) < 0)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }
            return -1;
        }

        public static int BinarySearchCancel(CustomList<OrderDetails> orderList, string searchElement)
        {
            int start = 0; int end = orderList.Count - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (orderList[middle].UserID == searchElement)
                {
                    return middle;
                }
                else if (string.Compare(orderList[middle].UserID, searchElement) < 0)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }
            return -1;
        }

        public static int BinarySearchModify(CustomList<UserDetails> userList, string searchElement)
        {
            int start = 0; int end = userList.Count - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (userList[middle].UserID == searchElement)
                {
                    return middle;
                }
                else if (string.Compare(userList[middle].UserID, searchElement) < 0)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }
            return -1;
        }
        public static int BinarySearchPuches(CustomList<UserDetails> userList, string searchElement)
        {
            int start = 0; int end = userList.Count - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (userList[middle].UserID == searchElement)
                {
                    return middle;
                }
                else if (string.Compare(userList[middle].UserID, searchElement) < 0)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }
            return -1;
        }

        // public static int BinarySearch(CustomList<CartItem> userList, string searchElement)
        // {
        //     int start = 0; int end = userList.Count - 1;
        //     while (start <= end)
        //     {
        //         int middle = (start + end) / 2;
        //         if (userList[middle].UserID == searchElement)
        //         {
        //             return middle;
        //         }
        //         else if (string.Compare(userList[middle].UserID, searchElement) < 0)
        //         {
        //             start = middle + 1;
        //         }
        //         else
        //         {
        //             end = middle - 1;
        //         }
        //     }
        //     return -1;
        // }


        }
    }

