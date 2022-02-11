using System;

namespace DataStructure
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next  != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            System.Console.WriteLine(data+" inserted in th list ");
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                System.Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                System.Console.Write(temp.data +" ");
                temp = temp.next;
            }
        }

        public Node InsertFunc(int position, int data)
        {
            if(position < 1)
            {
                System.Console.WriteLine("Position is not valid.");
            }
            if (position == 1)
            {
                Node node1 = new Node(data);
                node1.next = this.head;
                head = node1;
            }
            else
            {
                while (position-- != 0 )
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;

                }
                if (position != 1)
                {
                    System.Console.WriteLine("Invalid position.");
                }
                
            }
            System.Console.WriteLine("\n inserting value "+data+" Postion "+position);
            return head.next;
            System.Console.WriteLine(head.next);
            
        }
    }
}