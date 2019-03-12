using System;

namespace Linked_List_Based_Queue_Class_Library
{
  public class MyCustomQueue
  {

    public class Node
    {
      public Patient Data { get; set; }
      public Node Next; // Default to null
    }

    public class Patient
    {
      public string Name { get; set; }
      public string Concern { get; set; }
    }

    public class LinkedList
    {
      protected Node Header { get; set; }
      protected Node Tail { get; set; }
      // Class constuctor
      public LinkedList()
      {
        Header = null;
        Tail = null;
      }

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
    }
  }
}
