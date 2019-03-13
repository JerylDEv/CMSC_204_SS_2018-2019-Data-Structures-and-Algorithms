using System;
using Linked_List_Based_Queue_Class_Library;

namespace Console_App.View
{
  public class ViewModel
  {
    // I created an index system that will act as an index and as a name to my Nodes.
    int patientCounter = 0;

    string index;

    CustomLinkedList myQueue = new CustomLinkedList();

    public string generateIndex(int count)
    {
      index = count.ToString();
      return index;
    }

    public Node generateNode(string patientIndex, string name, string concern)
    {
      Patient patientInformation = new Patient(patientIndex, name, concern);
      Node patientNode = new Node(patientInformation);
      return patientNode;
    }


    public void SignUpPage()
    {
      Console.Clear();
      Console.WriteLine("[1] Sign up for doctor's consultation");
      Console.WriteLine(" ");
      string name = null;
      while (string.IsNullOrWhiteSpace(name))
      {
        Console.Write("Patient name: \t");
        name = Console.ReadLine();
      }
      Console.WriteLine(" ");
      string concern = null;
      while (string.IsNullOrWhiteSpace(concern))
      {
        Console.Write("Patient's concern: \t");
        concern = Console.ReadLine();
      }
      patientCounter++;
      string patientIndex = generateIndex(patientCounter);
      myQueue.InsertToEnd(generateNode(patientIndex, name, concern));
      Console.WriteLine(" ");
      Console.Write("Press Enter key to continue...");
      Console.WriteLine(" ");
      Console.ReadLine();
    }

    public void EnterRoomPage()
    {
      Console.Clear();
      Console.WriteLine("[2] Enter room");
      Console.WriteLine(" ");
      myQueue.SearchAndPrintFirstNode();
      Console.WriteLine(" ");
      Console.Write("Press Enter key to continue...");
      Console.WriteLine(" ");
      Console.ReadLine();
    }

    public void BeginConsultationPage()
    {
      Console.Clear();
      Console.WriteLine("[3] Begin consultation");
      Console.WriteLine(" ");
      myQueue.SearchAndRemoveFirstNode();
      Console.WriteLine(" ");
      Console.Write("Press Enter key to continue...");
      Console.WriteLine(" ");
      Console.ReadLine();
    }

    public void ClosingTimePage()
    {
      Console.Clear();
      Console.WriteLine("[4] Closing time");
      Console.WriteLine(" ");
      myQueue.ClearQueue();
      Console.WriteLine(" ");
      Console.Write("Press Enter key to continue...");
      Console.WriteLine(" ");
      Console.ReadLine();
    }
  }
}