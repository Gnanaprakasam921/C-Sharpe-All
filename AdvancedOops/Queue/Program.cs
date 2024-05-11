using System;
using System.Collections.Generic;
namespace QueueLib;
class Prrogram
{
    public static void Main(string[] args)
    {
        Queue<int> myQueue=new Queue<int>();
        myQueue.Enqueue(10);
        myQueue.Enqueue(20);
        myQueue.Enqueue(30);
        myQueue.Enqueue(40);
        myQueue.Enqueue(50);
        System.Console.WriteLine(myQueue.Count);

    }
}