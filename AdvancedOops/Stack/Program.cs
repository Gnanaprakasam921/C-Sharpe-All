using System;
using System.Collections;
using System.Collections.Generic;
namespace Stack1
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Stack<string> myStack=new Stack<string>();
            System.Console.WriteLine(myStack.Count);
            myStack.Clear();

            myStack.Push("one");
            myStack.Push("two");
            myStack.Push("three");

        }
    }
}
