using System;
using Linked_List_Based_Queue_Class_Library;

namespace Console_App
{
  class Program
  {
    static void Main(string[] args)
    {
      CustomLinkedList myQueue = new CustomLinkedList();
      // first patient
      Patient firstPatient = new Patient("apple", "apple");
      Node firstNode = new Node(firstPatient);
      // second patient
      Patient secondPatient = new Patient("banana", "banana");
      Node secondNode = new Node(secondPatient);
      // third patient
      Patient thirdPatient = new Patient("orange", "orange");
      Node thirdNode = new Node(thirdPatient);
      // fourth patient
      Patient fourthPatient = new Patient("lemon", "lemon");
      Node fourthNode = new Node(fourthPatient);
      myQueue.InsertToEnd(firstNode);
      myQueue.InsertToEnd(secondNode);
      myQueue.InsertToEnd(thirdNode);
      myQueue.Print();
      Console.WriteLine(" ");
      Console.WriteLine(" ");
      myQueue.InsertToBeginning(fourthNode);
      Console.WriteLine(" ");
      Console.WriteLine(" ");
      myQueue.Print();
      // Console.WriteLine(" ");
      // Console.WriteLine(" ");
      // thirdNode.Print();
      Console.WriteLine(" ");
      Console.WriteLine(" ");
      myQueue.RemoveNode(secondNode);
      myQueue.Print();
      Console.ReadLine();
    }
  }
}
