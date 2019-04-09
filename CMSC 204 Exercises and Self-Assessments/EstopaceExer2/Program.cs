using System;

namespace EstopaceExer2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            /* 
             * Jeryl Donato Estopace 
             * Student Number: 2018-30327
             * Date: 04/08/2019 
             * 
             * This console application is a linked list implementation of a binary search tree (BST).
             * I built this using .Net Core 3 preview. I chose .Net Core 3 so my console app could also could work on other platforms like Linux or Mac.
             * 
             * This console application is composed of the following files:
             *      1. Program.cs   -   Displays the main menu of the Console Application
             *      2. Pages.cs     -   Contains "pages" in the form of c# methods that represents each operation in the Program.cs file
             *      3. BinarySearchTree.cs  -   Declares the Root BST Node, and contains all the methods that are applicable to the BST Nodes
             *      4. BinarySearchTreeNode.cs  -   Declares the composition of a BST Node, contains the constructor and some methods that applies to each node.
             */

            Console.Title = "Linked List Based Binary Search Tree";
            Console.WriteLine("Linked List Based Binary Search Tree");

            Pages myPages = new Pages();

            bool displayMenu = true;

            while (displayMenu == true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Select an operation to perform:");
                Console.WriteLine("[1] Insert node to binary tree");
                Console.WriteLine("[2] Delete node from binary tree");
                Console.WriteLine("[3] Minimum");
                Console.WriteLine("[4] Maximum");
                Console.WriteLine("[5] Successor");
                Console.WriteLine("[6] Predecessor");
                Console.WriteLine("[7] Search");
                Console.WriteLine("[8] Print BST");
                Console.WriteLine("[9] Exit");
                Console.WriteLine(" ");
                Console.Write("Operation selected:\t");
                string operationSelected = Console.ReadLine();

                switch (operationSelected)
                {
                    case "1":
                        myPages.InsertNode();
                        displayMenu = true;
                        break;
                    case "2":
                        myPages.DeleteNode();
                        displayMenu = true;
                        break;
                    case "3":
                        myPages.MinimumNode();
                        displayMenu = true;
                        break;
                    case "4":
                        myPages.MaximumNode();
                        displayMenu = true;
                        break;
                    case "5":
                        myPages.SuccessorNode();
                        displayMenu = true;
                        break;
                    case "6":
                        myPages.PredecessorNode();
                        displayMenu = true;
                        break;
                    case "7":
                        myPages.SearchNode();
                        displayMenu = true;
                        break;
                    case "8":
                        myPages.PrintBST();
                        displayMenu = true;
                        break;
                    case "9":
                        displayMenu = false;
                        break;
                    default:
                        displayMenu = true;
                        break;
                }
            }
        }
    }
}

    