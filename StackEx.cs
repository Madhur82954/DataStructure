using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class StackEx
    {
        Node top;

        public StackEx()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node newnode = new Node(data);
            newnode.next = top;
            top = newnode;
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine(" |"+temp.Data+" |");
                    Console.WriteLine("------------");
                    temp = temp.next;
                }
            }
        }
        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                top = top.next;
            }
        }
        public void peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Peek element is : " + top.Data);
            }
        }
    }
}
