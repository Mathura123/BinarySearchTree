using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BSTProblem
{
    class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> rootNode;
        private int nodeCount=0;
        public BinarySearchTree()
        {
        }
        public BinarySearchTree(T[] datas)
        {
            foreach (T data in datas)
            {
                Insert(data);
            }
        }
        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (rootNode == null)
            {
                rootNode = newNode;
                nodeCount++;
            }
            else
            {
                Node<T> tempNode = rootNode;
                bool nodePositionFound = false;
                while (!nodePositionFound)
                {
                    if (data.CompareTo(tempNode.data) <= 0)
                    {
                        if (tempNode.leftNode == null)
                        {
                            newNode.parentNode = tempNode;
                            tempNode.leftNode = newNode;
                            nodePositionFound = true;
                            nodeCount++;
                        }
                        else
                            tempNode = tempNode.leftNode;
                    }
                    else
                    {
                        if (tempNode.rightNode == null)
                        {
                            newNode.parentNode = tempNode;
                            tempNode.rightNode = newNode;
                            nodePositionFound = true;
                            nodeCount++;
                        }
                        else
                            tempNode = tempNode.rightNode;
                    }
                }
            }
            Console.WriteLine($"INSERTED {data}");
        }
        public void GetSize()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Size of BST is {nodeCount}"); 
        }
        public void Display()
        {
            Console.WriteLine("--------------------");
            try
            {
                rootNode.PrintPretty("", NodePosition.center, true, false);
            }
            catch 
            {
                Console.WriteLine("BST is Empty");
            }
        }
    }
}

