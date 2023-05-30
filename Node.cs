using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Node
    {
        public int Data;
        public Node next;
        public Node(int data)
        {
            Data = data;
            next = null;
        }
    }
}
