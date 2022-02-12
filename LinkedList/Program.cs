using System;

namespace DataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.InsertFuncAtPerticularPostion(2,40);
            list.Display();
            list.AddInReversrOrder(25);
            list.Display();
            list.RemoveFirstNode();
            list.Display();
            list.RemoveLastNode();
            list.Display();
            list.Search(56);
            list.DeleteNodeAtPerticularPosition(2);
            list.Display();
            list.size();
            list.Display();
        }
    }
}


