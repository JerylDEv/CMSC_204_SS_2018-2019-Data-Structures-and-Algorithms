using System;
using Array_Based_Stack_Class_Library;

namespace Console_App.View
{
  // This Class handles the pages or views in each option.
  public class ViewModel
  {
    MyCustomStack notebookOwners = new MyCustomStack();


    public void AddNotebookPage()
    {
      Console.Clear();
      Console.WriteLine("[1] Add Notebook");
      Console.WriteLine(" ");
      string owner = null;
      while (string.IsNullOrWhiteSpace(owner))
      {
        Console.Write("Enter a name: \t");
        owner = Console.ReadLine();
      }
      Console.WriteLine(" ");
      // string owner = Console.ReadLine();
      notebookOwners.Push(owner);
      Console.WriteLine(" ");
      Console.WriteLine("Press Enter key to continue...");

      Console.ReadLine();
    }

    public void CheckNotebookPage()
    {
      Console.Clear();
      Console.WriteLine("[2] Check Notebook");
      Console.WriteLine(" ");
      notebookOwners.PeekAndPop();
      Console.WriteLine(" ");
      Console.WriteLine("Press Enter key to continue...");
      Console.ReadLine();
    }

    public void PeekAtNotebookPage()
    {
      Console.Clear();
      Console.WriteLine("[3] Peek at Notebook");
      Console.WriteLine(" ");
      notebookOwners.Peek();
      Console.WriteLine(" ");
      Console.WriteLine("Press Enter key to continue...");
      Console.ReadLine();
    }

    public void CheckAllNotebooksPage()
    {
      Console.Clear();
      Console.WriteLine("[4] Check All");
      Console.WriteLine(" ");
      notebookOwners.ClearStack();
      Console.WriteLine(" ");
      Console.WriteLine("Press Enter key to continue...");
      Console.ReadLine();
    }
  }
}