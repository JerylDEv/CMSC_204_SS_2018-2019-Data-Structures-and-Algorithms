using System;

namespace Linked_List_Based_Queue_Class_Library
{
  public class Node
  {
    public Patient Data { get; set; }
    public Node Next; // Default to null

    // Class Constructor
    public Node(Patient patientInfo)
    {
      Data = patientInfo;
      Next = null;
    }

    public void Print()
    {
      Console.WriteLine($"| [{Data.Index}]\t Name: {Data.Name},\t Concern: {Data.Concern} |");
      if (Next != null)
      {
        Next.Print();
      }
    }

    public void Print(string index)
    {
      if (Data.Index == index)
      {
        Console.WriteLine($"| [{Data.Index}]\t Name: {Data.Name},\t Concern: {Data.Concern} |");
      }
      else
      {
        Console.WriteLine("Patient appointment schedule not found.");
      }
    }

  }
}