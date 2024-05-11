using System;
namespace List
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create custom list for add 
            CustomList<int> customList = new CustomList<int>();
            customList.Add(10);

            customList.Add(20);
            customList.Add(30);
            customList.Add(40);
            customList.Add(50);
            
            // Add the 2nd list to the 1st list 
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(1);
            numbers.Add(2);
            customList.AddRange(numbers);

            for (int i = 0; i < customList.Count; i++)
            {
                System.Console.WriteLine(customList[i]);

            }
            //foreach(int value in customList)
            // {
            //     System.Console.WriteLine(value);
            // }
           bool result=customList.Contain(40);
           System.Console.WriteLine(result);
            int position=customList.IndexOf(20);
            System.Console.WriteLine(position);
            customList.Insert(2, 100);
            customList.removeAt(2);
            customList.Remove(4);
            customList.InsertRange(2, numbers);
            customList.Reverse();
            customList.Sort();



        }
    }
}
