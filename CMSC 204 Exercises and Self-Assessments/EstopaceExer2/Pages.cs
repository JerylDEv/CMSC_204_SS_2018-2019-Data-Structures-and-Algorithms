using System;
using System.Collections.Generic;
using System.Text;

namespace EstopaceExer2
{
    public class Pages
    {
        /*
         * This are the pages that I placed in my looping case in the Program.cs file.
         * I created separate pages to represent each operation in the console application.
         * I built the pages using the methods from my Binary Search Tree Class
         */

        readonly BinarySearchTree myBinaryTree = new BinarySearchTree();
                
        public void InsertNode()
        {
            Console.Clear();
            Console.WriteLine("[1] Insert node to binary tree");
            Console.WriteLine(" ");
            string input = null;
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Enter a number:\t");
                input = Console.ReadLine();
            }
            int numberValue = Convert.ToInt32(input);
            myBinaryTree.Insert(numberValue);
            myBinaryTree.PrintTree();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Press Enter key to continue...");
            Console.ReadLine();
        }

        public void DeleteNode()
        {
            Console.Clear();
            Console.WriteLine("[2] Delete node from binary tree");
            Console.WriteLine(" ");
            if (myBinaryTree.rootNode == null) // return the message below if there is no node in the Binary Search Tree at all.
            {
                Console.WriteLine($"The Binary Search Tree is empty.");
            }
            else
            {
                string input = null;
                while (string.IsNullOrWhiteSpace(input))
                {
                    Console.Write("Enter a number:\t");
                    input = Console.ReadLine();
                }
                int numberValue = Convert.ToInt32(input);
                if (myBinaryTree.Search(numberValue) == null) // if the number is not in the binary search tree, return the message below
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Node {numberValue} is not found in the Binary Search Tree.");
                }
                else // otherwise, proceed with the deletion of the node
                {
                    myBinaryTree.Delete(numberValue);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Node {numberValue} has been deleted.");
                    myBinaryTree.PrintTree();
                    Console.WriteLine(" ");
                }               
            } 
            Console.WriteLine(" ");
            Console.Write("Press Enter key to continue...");
            Console.ReadLine();
        }

        public void MinimumNode()
        {
            Console.Clear();
            Console.WriteLine("[3] Minimum");
            Console.WriteLine(" ");
            if (myBinaryTree.rootNode == null) // return the message below if there is no node in the Binary Search Tree at all.
            {
                Console.WriteLine($"The Binary Search Tree is empty.");
            }
            else // otherwise, search for the minimum node.
            {
                int? minNumber = myBinaryTree.MinimumNodeSearch(); // check the max number
                if (myBinaryTree.rootNode.RightNode == null && myBinaryTree.rootNode.LeftNode == null) // display the message if it is the only node
                {
                    Console.WriteLine($"Node {minNumber} is the only node in the Binary Search Tree.");
                }
                else // otherwise, display the message below
                {
                    Console.Write("BST Nodes:\t");
                    myBinaryTree.InOrderTraversalDisplay();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine($"The smallest number in the Binary Search Tree is {minNumber}.");
                }
            }
            Console.WriteLine(" ");
            Console.Write("Press Enter key to continue...");
            Console.ReadLine();
        }

        public void MaximumNode()
        {
            Console.Clear();
            Console.WriteLine("[4] Maximum");
            Console.WriteLine(" ");
            if (myBinaryTree.rootNode == null) // return the message below if there is no node in the Binary Search Tree at all.
            {
                Console.WriteLine($"The Binary Search Tree is empty.");
            }
            else 
            {
                int? maxNumber = myBinaryTree.MaximumNodeSearch(); // check the max number
                if (myBinaryTree.rootNode.RightNode == null && myBinaryTree.rootNode.LeftNode == null) // display the message if it is the only node
                {
                    Console.WriteLine($"Node {maxNumber} is the only node in the Binary Search Tree.");
                }      
                else // otherwise, display the message below
                {
                    Console.Write("BST Nodes:\t");
                    myBinaryTree.InOrderTraversalDisplay();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine($"The largest number in the Binary Search Tree is {maxNumber}.");
                }
            }
            Console.WriteLine(" ");
            Console.Write("Press Enter key to continue...");
            Console.ReadLine();
        }

        public void SuccessorNode()
        {
            Console.Clear();
            Console.WriteLine("[5] Successor");
            Console.WriteLine(" ");
            if (myBinaryTree.rootNode == null) // return the message below if there is no node in the Binary Search Tree at all.
            {
                Console.WriteLine($"The Binary Search Tree is empty.");
            }
            else // otherwise, continue
            {
                string input = null;
                while (string.IsNullOrWhiteSpace(input)) // check if the input is a null or whitespace
                {
                    Console.Write("Enter a number:\t");
                    input = Console.ReadLine();
                }
                int numberValue = Convert.ToInt32(input); // convert the input to int data type

                if (myBinaryTree.Search(numberValue) == null) // if the number is not in the binary search tree, return the message below
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Node {numberValue} is not found in the Binary Search Tree.");
                }
                else // otherwise, proceed with the searching of the successor
                {
                    if (myBinaryTree.SuccessorNodeSearch(myBinaryTree.rootNode, numberValue) == null)
                    {
                        if (myBinaryTree.rootNode.RightNode == null && myBinaryTree.rootNode.LeftNode == null)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"The Successor node of {numberValue} is 'null' since it is the only node in the In Order Traversal of the Binary Search Tree.");
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"The Successor node of {numberValue} is 'null' since it is the last node in the In Order Traversal of the Binary Search Tree.");
                        }
                    }
                    else
                    {
                        int? successorNumber = myBinaryTree.SuccessorNodeSearch(myBinaryTree.rootNode, numberValue);
                        Console.WriteLine(" ");
                        Console.Write("BST Nodes:\t");
                        myBinaryTree.InOrderTraversalDisplay();
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine($"The Successor node of {numberValue} is {successorNumber}.");
                    }
                }
            }           
            Console.WriteLine(" ");
            Console.Write("Press Enter key to continue...");
            Console.ReadLine();
        }

        public void PredecessorNode()
        {
            Console.Clear();
            Console.WriteLine("[6] Predecessor");
            Console.WriteLine(" ");
            if (myBinaryTree.rootNode == null) // return the message below if there is no node in the Binary Search Tree at all.
            {
                Console.WriteLine($"The Binary Search Tree is empty.");
            }
            else // otherwise, continue
            {
                string input = null;
                while (string.IsNullOrWhiteSpace(input)) // check if the input is a null or whitespace
                {
                    Console.Write("Enter a number:\t");
                    input = Console.ReadLine();
                }
                int numberValue = Convert.ToInt32(input); // convert the input to int data type

                if (myBinaryTree.Search(numberValue) == null) // if the number is not in the binary search tree, return the message below
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Node {numberValue} is not found in the Binary Search Tree.");
                }
                else // otherwise, proceed with the searching of the successor
                {
                    if (myBinaryTree.PredecessorNodeSearch(myBinaryTree.rootNode, numberValue) == null)
                    {
                        if (myBinaryTree.rootNode.RightNode == null && myBinaryTree.rootNode.LeftNode == null)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"The Predecessor node of {numberValue} is 'null' since it is the only node in the In Order Traversal of the Binary Search Tree.");
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"The Predecessor node of {numberValue} is 'null' since it is the first node in the In Order Traversal of the Binary Search Tree.");
                        }
                    }
                    else
                    {
                        int? predecessorNumber = myBinaryTree.PredecessorNodeSearch(myBinaryTree.rootNode, numberValue);
                        Console.WriteLine(" ");
                        Console.Write("BST Nodes:\t");
                        myBinaryTree.InOrderTraversalDisplay();
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine($"The Predecessor node of {numberValue} is {predecessorNumber}.");
                    }
                }
            }           
            Console.WriteLine(" ");
            Console.Write("Press Enter key to continue...");
            Console.ReadLine();
        }

        public void SearchNode()
        {
            Console.Clear();
            Console.WriteLine("[7] Search");
            Console.WriteLine(" ");
            if (myBinaryTree.rootNode == null) // return the message below if there is no node in the Binary Search Tree at all.
            {
                Console.WriteLine($"The Binary Search Tree is empty.");
            }
            else // otherwise, proceed with the searching of the node
            {
                string input = null;
                while (string.IsNullOrWhiteSpace(input))
                {
                    Console.Write("Enter a number:\t");
                    input = Console.ReadLine();
                }
                int numberValue = Convert.ToInt32(input);
                if (myBinaryTree.Search(numberValue) == null)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Node {numberValue} is not found in the Binary Search Tree.");
                    myBinaryTree.PrintTree(); // show the tree
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Node {numberValue} is present in the Binary Search Tree.");
                    myBinaryTree.Search(numberValue); // do the search
                    myBinaryTree.PrintTree(); // show the tree
                    Console.WriteLine(" ");
                }
            }        
            Console.WriteLine(" ");
            Console.Write("Press Enter key to continue...");
            Console.ReadLine();
        }
       
        public void PrintBST()
        {
            Console.Clear();
            Console.WriteLine("[8] Print BST");
            Console.WriteLine(" ");
            if (myBinaryTree.rootNode == null) // return the message below if there is no node in the Binary Search Tree at all.
            {
                Console.WriteLine($"The Binary Search Tree is empty.");
            }
            else // otherwise, proceed with the printing of the in order traversal
            {
                Console.Write("BST Nodes:\t");
                myBinaryTree.InOrderTraversalDisplay();
                Console.WriteLine(" ");
                myBinaryTree.PrintTree();
                Console.WriteLine(" ");
            }           
            Console.WriteLine(" ");
            Console.Write("Press Enter key to continue...");
            Console.ReadLine();
        }
    }
}
