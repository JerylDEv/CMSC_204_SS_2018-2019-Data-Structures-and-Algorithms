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
      if (Header == null)
      {
        Console.WriteLine("Congratulations! The queue is now empty.");
      }
      else
      {
        Console.WriteLine("Here are the remaining patients in the queue.");
        Header.Print();
      }
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
            previousNode.Next = currentNode.Next; // make the next node of the currentNode as currentNode.
          }
          else // Or else, if there is no existing node previously . . .
          {
            Header = Header.Next; // make the next node as the currentNode.
          }
          break; // break the while loop
        }
        previousNode = currentNode;
        node = node.Next;
      }
    }

    public void ClearQueue()
    {
      Node currentNode = Header;

      if (currentNode == null)
      {
        Console.WriteLine("The queue is empty.");
      }
      else
      {
        Header = null;
        Tail = null;
        Console.WriteLine("Congratulations! The queue is now empty.");
      }
    }

    public Node SearchNode(string patientIndex)
    {
      Node currentNode = Header;
      while ((currentNode != null) && (currentNode.Data.Index != patientIndex))
      {
        currentNode = currentNode.Next;
      }
      return currentNode;
    }

    public void SearchAndPrintFirstNode()
    {
      Node firstNode = Header;
      if (firstNode == null)
      {
        Console.WriteLine("The queue is empty.");
      }
      else
      {
        firstNode.Print(firstNode.Data.Index); // The Print method here comes from the Node class
      }
    }
    public void SearchAndRemoveFirstNode()
    {
      Node firstNode = Header;
      if (firstNode == null)
      {
        Console.WriteLine("The queue is empty.");
      }
      else
      {
        firstNode.Print(firstNode.Data.Index); // The Print method here comes from the Node class
        Console.WriteLine(" ");
        this.RemoveNode(firstNode);
        Console.WriteLine($"Patient number {firstNode.Data.Index} is now removed from the queue.");
        Console.WriteLine(" ");
        this.Print(); // this keyword here means that I am referring to the Print method within my LinkedList class.
      }
    }
  }
}