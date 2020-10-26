using System;

namespace BSTProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BST Problem Assignment");
            Console.WriteLine("=================================");
            BinarySearchTree<int> bstObj = new BinarySearchTree<int>(new[] { 2, 3, 5 });
            bstObj.Insert(9);
            bstObj.Insert(9);
            bstObj.Insert(86);
            bstObj.Insert(8);
            bstObj.Insert(6);
            bstObj.Insert(80);
        }
    }
}
