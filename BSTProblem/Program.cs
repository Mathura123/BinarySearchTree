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
            bstObj.Insert(56);
            bstObj.Insert(70);
            bstObj.Insert(95);
            bstObj.Insert(60);
            bstObj.Insert(65);
            bstObj.Insert(63);
            bstObj.Insert(67);
            bstObj.Insert(30);
            bstObj.Insert(22);
            bstObj.Insert(40);
            bstObj.Insert(11);
            bstObj.Insert(3);
            bstObj.Insert(16);
            bstObj.Display();
            bstObj.GetSize();
        }
    }
}
