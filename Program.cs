using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueEx queue = new QueueEx();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
            queue.Display();
            /*StackEx stack = new StackEx();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.peek();
            stack.IsEmpty();*/
           // Console.WriteLine("\n\n");
           // stack.pop();
            //stack.Display(); 
            /*LinkedList linked = new LinkedList();
            linked.AddNode(56);
            linked.AddNode(30);
            linked.AddNode(70);
            linked.Display();*/
        }
    }
}
