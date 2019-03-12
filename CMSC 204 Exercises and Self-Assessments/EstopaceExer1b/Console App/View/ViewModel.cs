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
      Console.WriteLine("[1] Sign up for doctor's consultation");
      Console.WriteLine(" ");
      string name = null;
      while (string.IsNullOrWhiteSpace(name))
      {
        Console.Write("Enter patient's name: \t");
        name = Console.ReadLine();
      }
      Console.WriteLine(" ");
      string concern = null;
      while (string.IsNullOrWhiteSpace(concern))
      {
        Console.Write("Enter patient's concern: \t");
        concern = Console.ReadLine();
      }
      patientCounter++;
      string patientIndex = generateIndex(patientCounter);
      myQueue.InsertToEnd(generateNode(patientIndex, name, concern));
      Console.ReadLine();
    }
  }
}