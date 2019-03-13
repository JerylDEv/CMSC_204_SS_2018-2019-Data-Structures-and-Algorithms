using System;
using Console_App.View;
using Linked_List_Based_Queue_Class_Library;

namespace Console_App
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Doctor Consultation App";
      Console.WriteLine("Doctor Consultation App");
      Console.WriteLine(" ");

      ViewModel myViewModel = new ViewModel();

      bool displayMenu = true;
      while (displayMenu == true)
      {
        Console.WriteLine("Select an operation to perform:");
        Console.WriteLine("[1] Sign up for doctor’s consultation");
        Console.WriteLine("[2] Enter room");
        Console.WriteLine("[3] Begin consultation");
        Console.WriteLine("[4] Closing time");
        Console.WriteLine("[5] Exit");
        Console.WriteLine(" ");
        Console.Write("Operation selected:\t");
        string operationSelected = Console.ReadLine();

        switch (operationSelected)
        {
          case "1":
            myViewModel.SignUpPage();
            displayMenu = true;
            break;
          case "2":
            myViewModel.EnterRoomPage();
            displayMenu = true;
            break;
          case "3":
            myViewModel.BeginConsultationPage();
            displayMenu = true;
            break;
          case "4":
            myViewModel.ClosingTimePage();
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
