using System;

namespace DataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            
            
        }
    }
}


