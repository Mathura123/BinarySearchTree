using System;

namespace BSTProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BST Problem Assignment");
            Console.WriteLine("=================================");
            BinarySearchTree<int> bstObj = new BinarySearchTree<int>();
            bstObj.Add(9);
            bstObj.Add(9);
            bstObj.Add(86);
            bstObj.Add(8);
            bstObj.Add(6);
            bstObj.Add(80);
        }
    }
}
