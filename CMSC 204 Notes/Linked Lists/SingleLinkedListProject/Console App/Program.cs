using System;
using Linked_List_Class_Library;

namespace Console_App
{
  class Program
  {
    static void Main(string[] args)
    {
      // SingleLinkedListClass LinkedList = new SingleLinkedListClass();
      // LinkedList.Hello();

      // Node myNode = new Node(15);
      // myNode.AddToEnd(32);
      // myNode.AddToEnd(45);
      // myNode.Print();

      MyLinkedList myList = new MyLinkedList();
      myList.AddToEnd(15);
      myList.AddToBeginning(27);
      myList.AddToEnd(42);
      myList.AddSorted(35);
      myList.Print();
      Console.WriteLine(" ");
      myList.RemoveNode(42);
      myList.Print();

      Console.ReadLine();
    }
  }
}
