using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            linked.AddNode(56);
            linked.AddNode(30);
            linked.AddNode(70);
            linked.Display();
        }
    }
}
