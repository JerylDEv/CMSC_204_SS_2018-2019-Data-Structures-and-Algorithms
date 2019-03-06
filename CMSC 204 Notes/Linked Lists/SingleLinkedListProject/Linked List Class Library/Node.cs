using System;

namespace Linked_List_Class_Library
{
  public class Node
  {
    public int data;
    public Node next;

    public Node(int i)
    {
      data = i;
      next = null;
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
    public void Print()
    {
      Console.Write($"|{data}| -> ");
      if (next != null)
      {
        next.Print();
      }
    }
  }

  public class Student
  {
    public int StudentID { get; set; }
    public string Name { get; set; }
    public Student(int studentId, string name)
    {
      StudentID = studentId;
      Name = name;
    }
  }
}