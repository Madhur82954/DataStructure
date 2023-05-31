using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* QueueEx queue = new QueueEx();
            queue.Enqueue(20);
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Display();
            queue.Dequeue();
            queue.Display();*/
            StackEx stack = new StackEx();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.peek();
            stack.IsEmpty();
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
