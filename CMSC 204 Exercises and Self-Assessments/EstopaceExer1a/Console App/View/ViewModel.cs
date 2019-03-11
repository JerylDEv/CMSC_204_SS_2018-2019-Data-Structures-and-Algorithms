using System;
using Array_Based_Stack_Class_Library;

namespace Console_App.View
{
  // This Class handles the views in each option.
  public class ViewModel
  {
    MyCustomStack notebookOwners = new MyCustomStack();


    public void AddNotebook()
    {
      Console.Write("Enter a name: \t");
      string owner = Console.ReadLine();
      notebookOwners.Push(owner);
      Console.ReadLine();
    }

    public void CheckNotebook()
    {
      notebookOwners.PeekAndPop();
      Console.ReadLine();
    }

    public void PeekAtNotebook()
    {
      notebookOwners.Peek();
      Console.ReadLine();
    }
  }
}