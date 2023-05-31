using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class QueueEx
    {
        Node Front;
        Node Rear;
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (Front == null)
            {
                Front = newnode;
                Rear = Front;
            }
            else
            {
                Rear.next = newnode;
                Rear = Rear.next;
            }
        }
        public void Dequeue()
        {
            if(Front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("{0} is Deleted",Front.Data);
            }
            Front = Front.next;
        }
        public void Display()
        {
            if (Front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node temp = Front;
                while (temp != null)
                {
                    Console.Write(" | " + temp.Data + " | ");
                    temp = temp.next;
                }
            }
        }
    }
}
