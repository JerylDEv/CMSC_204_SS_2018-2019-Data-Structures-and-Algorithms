using System;

namespace Linked_List_Based_Queue_Class_Library
{
  public class CustomLinkedList
  {

    protected Node Header { get; set; }
    protected Node Tail { get; set; }

    // Class constuctor
    public CustomLinkedList()
    {
      Header = null;
      Tail = null;
    }

    // This InsertToEnd method adds a Node at the end of the Linked List.
    public void InsertToEnd(Node newNode)
    {
      if (Header == null)
      {
        Header = newNode;
        Tail = newNode;
      }
      else
      {
        Tail.Next = newNode;
        Tail = newNode;
      }
    }

    // This Print method will print the Data (which contains the Name and the Concern of the Patient) of each Node.
    public void Print()
    {
      Header.Print();
    }

    public void InsertToBeginning(Node newNode)
    {
      if (Header == null)
      {
        Header = newNode;
        Tail = newNode;
      }
      else
      {
        Node temp = newNode; // Create a new Node called temp that will store the Patients data
        temp.Next = Header; // Move the original Header Node to the Next of the temp Node
        Header = temp; // transfer the temp Node data to the Header Node
      }
    }

    public void RemoveNode(Node existingNode)
    {
      var node = Header;
      Node currentNode = Header;
      Node previousNode = null;
      while (node != null)
      {
        currentNode = node;
        if (node == existingNode)
        {
          if (previousNode != null) // If there is an existing node previously . . .
          {
            previousNode.Next = currentNode.Next; // make the next node of the current as current.
          }
          else // Or else, if there is no existing node previously . . .
          {
            Header = Header.Next; // make the next node as the current.
          }
          break; // break the while loop
        }
        previousNode = currentNode;
        node = node.Next;
      }
    }
  }
}