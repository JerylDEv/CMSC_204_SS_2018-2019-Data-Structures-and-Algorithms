using System;
using System.Collections.Generic;
using System.Text;

namespace EstopaceExer2
{
    public class BinarySearchTreeNode
    {
        /*
         *  Composition of a Binary Search Tree Node 
         *      1. Node Number integer
         *      2. Left Child Node
         *      3. Right Child Node
         */
 
        public int NodeNumber { get; set; } // Data is where we will store int number

        public BinarySearchTreeNode LeftNode { get; set; } // Left Child Node

        public BinarySearchTreeNode RightNode { get; set; } // Right Child Node



        /* Binary Search Tree Constructor */

        public BinarySearchTreeNode(int numberValue)
        {
            NodeNumber = numberValue;
        }



        /* Methods */

        // Add a BST Node
        public void Insert(int numberValue)
        {
            if (numberValue >= NodeNumber) // if the number which we are adding is greater than or equal to the NodeNumber of the node which calls this method, then go to right 
            {
                if (RightNode == null) // if there is no right child node yet, then let's create one.
                {
                    RightNode = new BinarySearchTreeNode(numberValue);
                }
                else
                {
                    RightNode.Insert(numberValue); // otherwise, recursively call the Insert method on the existing right child node
                }
            }
            else // if the number which we are adding is less than the NodeNumber of the node which calls this method, then go to left 
            {
                if (LeftNode == null) // if there is no left child node yet, then let's create one.
                {
                    LeftNode = new BinarySearchTreeNode(numberValue);
                }
                else
                {
                    LeftNode.Insert(numberValue); // otherwise, recursively call the Insert method on the existing left child node
                }
            }
        }

        // Search the BST Node
        public BinarySearchTreeNode Search(int numberValue)
        {
            BinarySearchTreeNode currentNode = this; // this is the starting current node

            while (currentNode != null) // loop through all the nodes in a Binary Search Tree
            {
                if (numberValue == currentNode.NodeNumber) // if the number that we are looking for is equal to the NodeNumber of the current BST Node, then return the current BST Node
                {
                    return currentNode; 
                }
                else if (numberValue < currentNode.NodeNumber) // if the number that we are looking for is less than the NodeNumber of the current BST node, then go to the left child.
                    
                {
                    currentNode = currentNode.LeftNode;
                }
                else // if the number that we are looking for is greater than the NodeNumber of the current BST node, then go to the right child.
                {
                    currentNode = currentNode.RightNode;
                }
            }
            return null; // if no NodeNumber of the current node matches the number that we are looking for, then return null
        }

        // Minimum Node Search       
        public int? MinimumNodeSearch()
        {
            if (LeftNode == null) // once we reach the leftmost number in the left side of the tree, then we return the number
            {
                return NodeNumber;
            }
            else // otherwise, we return just repeat the search
            {
                return LeftNode.MinimumNodeSearch();
            }
        }

        // Maximum Node Search
        public int? MaximumNodeSearch()
        {
            if (RightNode == null) // once we reach the rightmost number in the right side of the tree, then we return the number
            {
                return NodeNumber;
            }
            else // otherwise, we return just repeat the search
            {
                return RightNode.MaximumNodeSearch();
            }
        }

        // My In Order Traversal method arranges my nodes from left to root to right in an ascending order.
        public void InOrderTraversal()
        {
            if (LeftNode != null)
            {
                LeftNode.InOrderTraversal();
            }

            Console.Write($"{NodeNumber} ");

            if (RightNode!=null)
            {
                RightNode.InOrderTraversal();
            }
        }
    }
}
