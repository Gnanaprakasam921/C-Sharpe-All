using System;
using System.Collections.Generic;
namespace CustomStack 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Stack<int> myStack=new Stack<int>();
            myStack.Push(11);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);
            System.Console.WriteLine(myStack.Peek()); // it used for which is last push element in stack it will return
            System.Console.WriteLine(myStack.Peek());
            System.Console.WriteLine(myStack.Pop());
            System.Console.WriteLine(myStack.Pop());
        }
    }
}
