using System;       
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class LinkedList
    {
        Node head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next=node;
            }
            Console.WriteLine("{0} is added in Linked List",node.Data);
        }
        public void Display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Linked List is Empty");
                Console.ResetColor();
            }
            while (temp != null)
            {
                Console.Write(+temp.Data+" ");
                temp = temp.next;
            }           
        }
        public void DeleteNode()
        {
            Node temp = head;
            if(head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                head = head.next;
            }
        }
        public void AddReverse(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                Node temp = head;
                head.next = newnode;
                head = newnode;
            }
        }
    }
}
