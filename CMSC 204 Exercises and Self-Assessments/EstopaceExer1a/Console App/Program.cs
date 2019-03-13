using System;
using Console_App.View;

namespace Console_App
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Notebook Checker App";
      Console.WriteLine("Notebook Checker App");

      ViewModel myViewModel = new ViewModel();

      bool displayMenu = true;
      while (displayMenu == true)
      {
        Console.WriteLine(" ");
        Console.WriteLine("Select an operation to perform:");
        Console.WriteLine("[1] Add Notebook");
        Console.WriteLine("[2] Check Notebook");
        Console.WriteLine("[3] Peek at Notebook");
        Console.WriteLine("[4] Check All");
        Console.WriteLine("[5] Exit");
        Console.WriteLine(" ");
        Console.Write("Operation selected:\t");
        string operationSelected = Console.ReadLine();

        switch (operationSelected)
        {
          case "1":
            myViewModel.AddNotebookPage();
            displayMenu = true;
            break;
          case "2":
            myViewModel.CheckNotebookPage();
            displayMenu = true;
            break;
          case "3":
            myViewModel.PeekAtNotebookPage();
            displayMenu = true;
            break;
          case "4":
            myViewModel.CheckAllNotebooksPage();
            displayMenu = true;
            break;
          case "5":
            displayMenu = false;
            break;
          default:
            displayMenu = true;
            break;
        }
      }
    }
  }
}
