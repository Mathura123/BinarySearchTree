using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProblem
{
    public enum NodePosition
    {
        leftNode,
        rightNode,
        center
    }
    public class Node<T> : IComparable where T : IComparable
    {
        
        public T data;
        public Node<T> parentNode;
        public Node<T> leftNode;
        public Node<T> rightNode;
        public Node(T data)
        {
            this.data = data;
        }
        public int CompareTo(object obj)
        {
            T nodeData = (T)obj;
            if (data.CompareTo(nodeData) < 0)
                return -1;
            if (data.CompareTo(nodeData) > 0)
                return 1;
            else
                return 0;
        }
        private void PrintValue(string value, NodePosition nodePostion)
        {
            switch (nodePostion)
            {
                case NodePosition.leftNode:
                    PrintLeftValue(value);
                    break;
                case NodePosition.rightNode:
                    PrintRightValue(value);
                    break;
                case NodePosition.center:
                    Console.WriteLine(value);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
        private void PrintLeftValue(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("L:");
            Console.ForegroundColor = (value == "-") ? ConsoleColor.Yellow : ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private void PrintRightValue(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("R:");
            Console.ForegroundColor = (value == "-") ? ConsoleColor.Yellow : ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void PrintPretty(string indent, NodePosition nodePosition, bool last, bool empty)
        {

            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }

            var stringValue = empty ? "-" : data.ToString();
            PrintValue(stringValue, nodePosition);

            if (!empty && (this.leftNode != null || this.rightNode != null))
            {
                if (this.leftNode != null)
                    this.leftNode.PrintPretty(indent, NodePosition.leftNode, false, false);
                else
                    PrintPretty(indent, NodePosition.leftNode, false, true);

                if (this.rightNode != null)
                    this.rightNode.PrintPretty(indent, NodePosition.rightNode, true, false);
                else
                    PrintPretty(indent, NodePosition.rightNode, true, true);
            }
        }
    }
}
