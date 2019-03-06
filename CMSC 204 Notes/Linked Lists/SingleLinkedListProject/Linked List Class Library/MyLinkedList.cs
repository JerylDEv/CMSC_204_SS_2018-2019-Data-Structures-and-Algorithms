using System;

namespace Linked_List_Class_Library
{
  public class MyLinkedList
  {
    public Node headNode;
    public MyLinkedList()
    {
      headNode = null;
    }

    public void Print()
    {
      // Call the Print method from the Node Class
      headNode.Print();
    }

    public void AddToEnd(int data)
    {
      if (headNode == null)
      {
        headNode = new Node(data);
      }
      else
      {
        // Call the AddToEnd method from the Node Class
        headNode.AddToEnd(data);
      }
    }

    public void AddToBeginning(int data)
    {
      if (headNode == null)
      {
        headNode = new Node(data);
      }
      else
      {
        // Create a new Node called temp that will store the data
        Node temp = new Node(data);
        // point the temporary node's next pointer to the headNode
        temp.next = headNode;
        // adjust the headNode to point to the temp
        headNode = temp;
      }
    }

    public void AddSorted(int data)
    {
      if (headNode == null)
      {
        headNode = new Node(data);
      }
      else if (data < headNode.data)
      {
        AddToBeginning(data);
      }
      else
      {
        headNode.AddSorted(data);
      }
    }
  }
}