using System;
using System.Collections.Generic;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Dictionary<string, MyLinkedListNode<string, int>> hashTable = new Dictionary<string, MyLinkedListNode<string, int>>();

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                string key = word.ToLower();

                if (key == "avoidable")
                {
                    continue; // Skip the word "avoidable"
                }

                if (hashTable.ContainsKey(key))
                {
                    MyLinkedListNode<string, int> node = hashTable[key];
                    node.Value++;
                }
                else
                {
                    MyLinkedListNode<string, int> newNode = new MyLinkedListNode<string, int>(key, 1);
                    hashTable[key] = newNode;
                }
            }
            Console.WriteLine("Word Frequency:");
            foreach (var data in hashTable.Values)
            {
                Console.WriteLine($"{data.Key}: {data.Value}");
            }
            /*QueueEx queue = new QueueEx();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
            queue.Display();*/
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

            /*Tree tree = new Tree();
            tree.Insert(56);
            tree.Insert(30);
            tree.Insert(70);
            tree.PreOrder();*/
        }
    }
}
