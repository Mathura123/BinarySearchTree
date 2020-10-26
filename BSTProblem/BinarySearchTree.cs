using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> rootNode;
        public BinarySearchTree()
        {
        }
        public BinarySearchTree(T[] datas)
        {
            foreach(T data in datas)
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
                            tempNode.leftNode = newNode;
                            nodePositionFound = true;
                        }
                        else
                            tempNode = tempNode.leftNode;
                    }
                    else
                    {
                        if (tempNode.rightNode == null)
                        {
                            tempNode.rightNode = newNode;
                            nodePositionFound = true;
                        }
                        else
                            tempNode = tempNode.rightNode;
                    }
                }
            }
            Console.WriteLine($"INSERTED {data}");
        }
    }
}

