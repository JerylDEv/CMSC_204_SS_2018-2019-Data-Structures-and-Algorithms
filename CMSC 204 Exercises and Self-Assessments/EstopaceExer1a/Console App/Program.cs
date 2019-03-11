using System;
using Console_App.View;

namespace Console_App
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Notebook Checker App";

      ViewModel myViewModel = new ViewModel();

      bool displayMenu = true;
      while (displayMenu == true)
      {
        Console.WriteLine("Select an operation to perform:");
        Console.WriteLine("1) Add Notebook");
        Console.WriteLine("2) Check Notebook");
        Console.WriteLine("3) Peek at Notebook");
        Console.WriteLine("4) Check All");
        Console.WriteLine("5) Exit");
        Console.WriteLine(" ");
        Console.Write("Operation selected:\t");
        string operationSelected = Console.ReadLine();

        if (operationSelected == "1")
        {
          myViewModel.AddNotebook();
          displayMenu = true;
        }
        else if (operationSelected == "2")
        {
          myViewModel.CheckNotebook();
          displayMenu = true;
        }
        else if (operationSelected == "3")
        {
          myViewModel.PeekAtNotebook();
          displayMenu = true;
        }
        else if (operationSelected == "4")
        {
          myViewModel.CheckAllNotebooks();
          displayMenu = true;
        }
        else if (operationSelected == "5")
        {

          displayMenu = false;
        }
        else
        {
          displayMenu = true;
        }
      }
    }
  }
}
