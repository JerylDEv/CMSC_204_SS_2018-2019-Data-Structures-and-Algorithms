using System;
using System.Collections.Generic;
using System.Text;

namespace EstopaceExer2
{
    public class BinarySearchTree
    {
        /*
         * This is my Binary Search Tree class where I placed all of my methods that applies to my BST Nodes
         */

        public BinarySearchTreeNode rootNode; // this is the topmost node of the Binary Search Tree



        /* Methods */

        // Add the BST Tree Node
        public void Insert(int numberValue)
        {
            if (rootNode != null) // if there is an existing root node, then add the node using the Insert method from the BinarySearchTreeNode class.
            {
                rootNode.Insert(numberValue);
            }
            else // otherwise, create a root node
            {
                rootNode = new BinarySearchTreeNode(numberValue); // this will call our BST Node Constructor
            }
        }

        // Search the BST Tree Node
        public BinarySearchTreeNode Search(int numberValue)
        {
            if (rootNode != null) // if there is an existing root node, then we call the Search method from the BST Node Class
            {
                return rootNode.Search(numberValue);
            }
            else
            {
                return null; // otherwise, return null
            }
        }

        // Delete the BST Tree Node
        public void Delete(int numberValue)
        {
            /* First Part:      Look for the Node */

            // This is our starting point BST Node
            BinarySearchTreeNode currentNode = rootNode;
            BinarySearchTreeNode parentNode = rootNode;

            // this is to monitor which child node should be deleted;
            bool isLeftNode = false;

            // in case of an empty tree
            if (currentNode == null)
            {
                return; // end the method call because there is nothing to return
            }

            // Search the Node. Notice that this is somewhat similar to my Search Method
            while (currentNode != null && currentNode.NodeNumber != numberValue)
            {
                parentNode = currentNode; // set the currentNode as the parent

                if (numberValue < currentNode.NodeNumber) // if the number which we are searching for is less than the current nodes' number, then let's go to the left and look for the node
                {
                    currentNode = currentNode.LeftNode;
                    isLeftNode = true;
                }
                else // otherwise, we go right and look for the node
                {
                    currentNode = currentNode.RightNode;
                    isLeftNode = false;
                }
            }

            // this is to end the method in case the node to delete is not found after the 'while' traversal in the earlier code.
            if (currentNode == null)
            {
                return;
            }

            /* Second Part:     Act depending on the current node's number of child nodes */

            // A. In case the current node found has no children (a leaf node)
            if (currentNode.LeftNode == null && currentNode.RightNode == null)
            {
                // if the leaf node is the root node, then set the root to null;
                if (rootNode == currentNode)
                {
                    rootNode = null;
                }
                else // if it is not, then
                {
                    if (isLeftNode == true) // if it is a left node, thendo not make it a left child node
                    {
                        parentNode.LeftNode = null;
                    }
                    else // if it is a right node, then do not make it a right child node
                    {
                        parentNode.RightNode = null; 
                    }
                }
            }
            // B. In case the current node found only has a right child node
            else if (currentNode.LeftNode == null)
            {
                if (currentNode == rootNode) // if the current node we found is the root, then we make its right node as the new root.
                {
                    rootNode = currentNode.RightNode;
                }
                else // if the current node which we found is not the root, then check
                {
                    if (isLeftNode == true) // is the current node a left node of its parent node?
                    {
                        parentNode.LeftNode = currentNode.RightNode; // if yes, then make the current node's right child node the parent node's new left node
                    }
                    else
                    {
                        parentNode.RightNode = currentNode.RightNode; // if not, then make the current node's right child node the parent node's new right node
                    }
                }               
            }
            // C. In case the current node found only has a left child node
            else if (currentNode.RightNode == null)
            {
                if (currentNode == rootNode) // if the current node we found is the root, then we make its left node as the new root.
                {
                    rootNode = currentNode.LeftNode;
                }
                else // if the current node which we found is not the root, then check
                {
                    if (isLeftNode == true) // is the current node a left node of its parent node?
                    {
                        parentNode.LeftNode = currentNode.LeftNode; // if yes, then make the current node's left child node the parent node's new left node
                    }
                    else
                    {
                        parentNode.RightNode = currentNode.LeftNode; // if not, then make the current node's left child node the parent node's new right node
                    }
                }
            }
            // D. In case the current node found has bothe left and right children nodes
            // In this case, we can go to the right node and search for the leaf node of its left child node. This will be the nearest bigger number to the current node's NodeNumber (successor node).
            // If it has a right child node, the right child node will become the left child of the parent of the successor node.
            else
            {
                // Search for a successor node (which is the nearest bigger number to the current node's number)
                BinarySearchTreeNode successor = GetSuccessor(currentNode);
                // if the current node is the root, then the new root will be the successor node
                if (currentNode == rootNode)
                {
                    rootNode = successor;
                }
                else if (isLeftNode == true) 
                {
                    parentNode.LeftNode = successor; // if this happens to be the left node, then make the parent's left child node as the successor 
                }
                else
                {
                    parentNode.RightNode = successor; // if this happens to be the right node, then make the parent's right child node as the successor
                }
            }
        }

        // Search Successor Node method that takes in a Node instead of an integer.
        // I'm exclusively using this for my Delete Method to assist in the re-arranging of my nodes after deletion.
        public BinarySearchTreeNode GetSuccessor(BinarySearchTreeNode node)
        {
            BinarySearchTreeNode parentNodeOfSuccessor = node;
            BinarySearchTreeNode successorNode = node;
            BinarySearchTreeNode currentRightNode = node.RightNode;

            // check each left child node on the right child node
            while (currentRightNode != null)
            {
                parentNodeOfSuccessor = successorNode;
                successorNode = currentRightNode;
                currentRightNode = currentRightNode.LeftNode; // check the next left node
            }
            // if the successor is not just the right node (which means that there is a left node nearest to the actual current node)
            if (successorNode != node.RightNode) 
            {
                // then make the left node of the successor's parent node, as the right child node of the successor if it has one.
                parentNodeOfSuccessor.LeftNode = successorNode.RightNode;
                // connect the right child node of the node to be deleted, to the successor node's right node.
                successorNode.RightNode = node.RightNode;
            }
            // connect the left child node of the node to be deleted, to the successor node's left node.
            successorNode.LeftNode = node.LeftNode;

            return successorNode; // return the successor node
        }

        // Successor Node Search is my exclusive method for searching the successor of a node which accepts an integer instead of a node.
        // This is my favorite method which I created because this one gave me a lot of challenge.
        public int? SuccessorNodeSearch(BinarySearchTreeNode rootNode,int numberValue)
        {
            BinarySearchTreeNode currentNode = Search(numberValue);
            if (currentNode.RightNode != null) // if the current node has a right child node, then let's search through all the left nodes of the current node
            {
                return currentNode.RightNode.MinimumNodeSearch(); // return the leftmost node of the right child node. aka, the minimum node of the right subtree.
            }
            else // otherwise, if there is no right subtree, then we search the node from the root and the node from where we take the last left turn 
            {
                BinarySearchTreeNode successorNode = null;
                BinarySearchTreeNode ancestorNode = rootNode;

                while (ancestorNode != currentNode) // continue to traverse, while the ancestor node is not equal to the current node we are searching
                {
                    if (currentNode.NodeNumber < ancestorNode.NodeNumber) // if the current number which we are searching is less than the root node,
                    {
                        successorNode = ancestorNode; // set the successor node as the ancestor node
                        ancestorNode = ancestorNode.LeftNode; // and the ancestor node will be its left child node
                    }
                    else // if the current number which we are searching is greater than the root node,
                    {
                        ancestorNode = ancestorNode.RightNode; // let's check the ancestor's right child node 
                    }
                }
                if (successorNode == null) // if no successor node is found, return null;
                {
                    return null;
                }
                else
                {
                    return successorNode.NodeNumber; // otherwise, return the successor node > number
                }
            }
        }

        // Predecessor Node Search is my exclusive method for searching the predecessor of a node which accepts an integer instead of a node.
        public int? PredecessorNodeSearch(BinarySearchTreeNode rootNode,int numberValue)
        {
            BinarySearchTreeNode currentNode = Search(numberValue);
            if (currentNode.LeftNode != null) // if the current node has a left child node, then let's search through all the right nodes of the current node
            {
                return currentNode.LeftNode.MaximumNodeSearch(); // return the rightmost node of the left child node. aka, the minimum node of the left subtree.
            }
            else // otherwise, if there is no left subtree, then we search the node from the root and the node from where we take the last right turn 
            {
                BinarySearchTreeNode predecessorNode = null;
                BinarySearchTreeNode ancestorNode = rootNode;

                while (ancestorNode != currentNode) // continue to traverse, while the ancestor node is not equal to the current node we are searching
                {
                    if (currentNode.NodeNumber > ancestorNode.NodeNumber) // if the current number which we are searching is greater than the root node,
                    {
                        predecessorNode = ancestorNode; // set the predecessor node as the ancestor node
                        ancestorNode = ancestorNode.RightNode; // and the ancestor node will be its right child node
                    }
                    else // if the current number which we are searching is less than the root node,
                    {
                        ancestorNode = ancestorNode.LeftNode; // let's check the ancestor's left child node 
                    }
                }
                if (predecessorNode == null) // if no predecessor node is found, return null;
                {
                    return null;
                }
                else // otherwise, return the predecessor node > number
                {
                    return predecessorNode.NodeNumber;
                }
            }
        }

        // Method to search the minimum number in the Binary Search Tree
        public int? MinimumNodeSearch()
        {
            if (rootNode != null) // Proceed with the search if we have a root node
            {
                return rootNode.MinimumNodeSearch();
            }
            else // otherwise, just return null
            {
                return null;
            }
        }

        // Method to search the maximum number in the Binary Search Tree
        public int? MaximumNodeSearch()
        {
            if (rootNode != null)
            {
                return rootNode.MaximumNodeSearch();
            }
            else
            {
                return null;
            }
        }

        // In Order Traversal display method to display numbers in an ascending order
        public void InOrderTraversalDisplay()
        {
            if (rootNode != null)
            {
                rootNode.InOrderTraversal(); // access the method from my Node class
            }
        }

        // Print Method to Print the whole tree
        public void PrintTree()
        {
            rootNode.Print(textFormat: "[0]", spacing: 2);
        }
    }

    // This is a separate class that handles that printing of the tree
    public static class BinaryTreePrinter
    {
        class NodeInformation
        {
            public BinarySearchTreeNode Node;
            public string Text;
            public int StartPos;
            public int Size { get { return Text.Length; } }
            public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
            public NodeInformation Parent, Left, Right;
        }

        public static void Print(this BinarySearchTreeNode root, /*default settings*/ string textFormat = "0", int spacing = 1, int topMargin = 2, int leftMargin = 2)
        {
            if (root == null) return;
            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInformation>();
            var next = root;
            for (int level = 0; next != null; level++)
            {
                var item = new NodeInformation { Node = next, Text = next.NodeNumber.ToString(textFormat) };
                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + spacing;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = leftMargin;
                    last.Add(item);
                }
                if (level > 0)
                {
                    item.Parent = last[level - 1];
                    if (next == item.Parent.Node.LeftNode)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos - 1);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos + 1);
                    }
                }
                next = next.LeftNode ?? next.RightNode;
                for (; next == null; item = item.Parent)
                {
                    int top = rootTop + 2 * level;
                    Print(item.Text, top, item.StartPos);
                    if (item.Left != null)
                    {
                        Print("/", top + 1, item.Left.EndPos);
                        Print("_", top, item.Left.EndPos + 1, item.StartPos);
                    }
                    if (item.Right != null)
                    {
                        Print("_", top, item.EndPos, item.Right.StartPos - 1);
                        Print("\\", top + 1, item.Right.StartPos - 1);
                    }
                    if (--level < 0) break;
                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos + 1;
                        next = item.Parent.Node.RightNode;
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos - 1;
                        else
                            item.Parent.StartPos += (item.StartPos - 1 - item.Parent.EndPos) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
        }

        private static void Print(string s, int top, int left, int right = -1)
        {
            
            Console.SetCursorPosition(left, top);
            if (right < 0) right = left + s.Length;
            while (Console.CursorLeft < right) Console.Write(s);
        }
    }
}