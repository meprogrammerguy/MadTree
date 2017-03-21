using System;
using System.Collections.Generic;
using System.Text;

namespace MadTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree theTree = new Tree();
            theTree.Insert(1);
            theTree.Insert(16);
            theTree.Insert(8);
            theTree.Insert(9);
            theTree.Insert(5);
            theTree.Insert(12);
            theTree.Insert(4);
            theTree.Insert(13);
            theTree.Insert(6);
            theTree.Insert(11);
            theTree.Insert(3);
            theTree.Insert(14);
            theTree.Insert(7);
            theTree.Insert(10);
            theTree.Insert(2);
            theTree.Insert(15);
            theTree.Insert(1);
            theTree.Insert(16);
            theTree.Insert(8);
            theTree.Insert(9);
            theTree.Insert(5);
            theTree.Insert(12);
            theTree.Insert(4);
            theTree.Insert(13);
            theTree.Insert(6);
            theTree.Insert(11);
            theTree.Insert(3);
            theTree.Insert(14);
            theTree.Insert(7);
            theTree.Insert(10);
            theTree.Insert(2);
            theTree.Insert(15);
            theTree.Insert(1);
            theTree.Insert(16);
            theTree.Insert(8);
            theTree.Insert(9);
            theTree.Insert(5);
            theTree.Insert(12);
            theTree.Insert(4);
            theTree.Insert(13);
            theTree.Insert(6);
            theTree.Insert(11);
            theTree.Insert(3);
            theTree.Insert(14);
            theTree.Insert(7);
            theTree.Insert(10);
            theTree.Insert(2);
            theTree.Insert(15);
            theTree.Insert(1);
            theTree.Insert(16);
            theTree.Insert(8);
            theTree.Insert(9);
            theTree.Insert(5);
            theTree.Insert(12);
            theTree.Insert(4);
            theTree.Insert(13);
            theTree.Insert(6);
            theTree.Insert(11);
            theTree.Insert(3);
            theTree.Insert(14);
            theTree.Insert(7);
            theTree.Insert(10);
            theTree.Insert(2);
            theTree.Insert(15);
            Console.WriteLine("Inorder Traversal: ");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal: ");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal: ");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}
