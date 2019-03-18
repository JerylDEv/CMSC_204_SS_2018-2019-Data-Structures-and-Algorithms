using System;
using Console_App.View;

namespace Console_App
{
  class Program
  {

    /* 
    Jeryl Donato Estopace 
    Student Number: 2018-30327
    Date: 3/18/2019

    Console App.exe is located in this path EstopaceExer1a\Console App\bin\Debug\netcoreapp2.2\win10-x64

    Brief Summary of what I did in the App

    In the Array Based Stack Class Library, I...
    1. created an array of string
    2. created a variable that act as a counter and tracker of the array index at the same time
    3. created the custom methods

    In the Console App > View folder, I...
    4. created the custom methods to resemble pages for each option in the persisting display menu.

    In the Console App, I...
    5. created the persisting menu option using while loop
    */

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
