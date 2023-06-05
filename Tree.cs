using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Tree
    {
        Node1 root;
        public Tree()
        {
            root = null;
        }
        public Node1 ReturnRoot()
        {
            return root; 
        }
        public void Insert(int data)
        {
            Node1 newnode = new Node1(data);
            if(root == null)
            {
                root = newnode;
            }
            else
            {
                Node1 current = root;
                Node1 parent;
                while (true)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newnode;
                            return;
                        }
                        else
                        {
                            current = current.right;
                            if (current == null)
                            {
                                parent.right = newnode;
                                return;
                            }
                        }
                    }
                }
            }
        }
        /*public void Display(Node1 root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data+" ");
                Display(root.left);
                Display(root.right);
            }
        }
        public void Display()
        {
            Display(root);
        }*/
        public void PreOrder(Node1 root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data + " ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }
        public void PreOrder()
        {
            PreOrder(root);
        }
        public void PostOrder(Node1 root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.WriteLine(root.data + " ");
            }
        }
        public void InOrder(Node1 root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.WriteLine(root.data + " ");
                InOrder(root.right);
            }
        }
    }
}
