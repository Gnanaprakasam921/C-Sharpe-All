using System;
namespace CustomQueue;
class Program 
{
    public static void Main(string[] args)
    {
        CusQueue<int> queList=new CusQueue<int>();
        queList.Enqueue(10);
        queList.Enqueue(20);
        queList.Enqueue(30);
        queList.Enqueue(40);

        // after grow the arrry we added the extra element;
        queList.Enqueue(50);
        queList.Enqueue(60);
        foreach(int queue in queList)
        {
            System.Console.WriteLine(queue);
        }

        System.Console.WriteLine(queList.Peek());
        System.Console.WriteLine(queList.Peek());
        foreach(int queue in queList)
        {
            System.Console.WriteLine(queue);
        }
        System.Console.WriteLine(queList.Dequeue());
        System.Console.WriteLine(queList.Dequeue());
        foreach(int queue in queList)
        {
            System.Console.WriteLine(queue);
        }





    }
}
