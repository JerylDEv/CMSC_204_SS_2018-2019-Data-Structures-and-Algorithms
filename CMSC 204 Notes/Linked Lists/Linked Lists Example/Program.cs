using System;

namespace Linked_Lists_Example
{
  class Program
  {
    // Create a public Node Class.
    public class Node
    {
      public int data;
      public Node next;
      public Node(int i)
      {
        data = i;
        next = null;
      }

      public void Print()
      {
        Console.Write($"|{data}| -> ");
        // perform recursion if the next data is not equal to null
        if (next != null)
        {
          next.Print();
        }
      }

      public void AddSorted(int data)
      {
        if (next == null)
        {
          next = new Node(data);
        }
        else if (data < next.data)
        {
          Node temp = new Node(data);
          temp.next = this.next;
          this.next = temp;
        }
        else
        {
          next.AddSorted(data);
        }
      }
      public void AddToEnd(int data)
      {
        if (next == null)
        {
          next = new Node(data);
        }
        else
        {
          next.AddToEnd(data);
        }
      }
    }

    public class MyList
    {
      public Node headNode;
      public MyList()
      {
        headNode = null;
      }


      public void AddToEnd(int data)
      {
        if (headNode == null)
        {
          headNode = new Node(data);
        }
        else
        {
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
          Node temp = new Node(data);
          temp.next = headNode;
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
      public void Print()
      {
        headNode.Print();
      }
    }
    static void Main(string[] args)
    {
      Node myNode = new Node(7);
      // myNode.next = new Node(17);
      // myNode.next.next = new Node(10);
      // myNode.next.next.next = new Node(9);
      myNode.AddToEnd(17);
      myNode.AddToEnd(10);
      myNode.AddToEnd(9);
      myNode.Print();

      Console.WriteLine(" ");

      MyList list = new MyList();
      list.AddToEnd(2);
      list.AddToEnd(24);
      list.AddToEnd(23);
      list.AddToEnd(29);
      list.Print();

      Console.WriteLine(" ");
      list.AddToBeginning(12);
      list.Print();
      Console.WriteLine(" ");

      MyList mySecondList = new MyList();
      mySecondList.AddSorted(12);
      mySecondList.AddSorted(121);
      mySecondList.AddSorted(15);
      mySecondList.AddSorted(45);
      mySecondList.Print();

      Console.ReadLine();
    }
  }
}
