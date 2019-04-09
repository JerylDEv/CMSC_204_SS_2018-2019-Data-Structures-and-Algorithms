using System;
using Console_App.View;
using Linked_List_Based_Queue_Class_Library;

namespace Console_App
{
    class Program
    {

        /* 
        Jeryl Donato Estopace 
        Student Number: 2018-30327
        Date: 3/18/2019

        Console App.exe is located in this path EstopaceExer1b\Console App\bin\Debug\netcoreapp2.2\win10-x64

        Brief Summary of what I did in the App

        In the Linked List Based Queue Class Library, I...
        1. created a patient class that acts as a template for patient data
        2. created a custom node class that contains the patient data and will identify the next node 
        3. created methods for the node only (i.e. print method to print the node)
        4. created a custom linked list class that will determine the header and tail 
        5. created custom methods for the linked list (e.g. insert to end method, print, etc.)

        In the Console App > View folder, I...
        6. created the custom methods to resemble pages for each option in the persisting display menu.

        In the Console App, I...
        7. created the persisting menu option using while loop
        */

        static void Main(string[] args)
        {
            Console.Title = "Doctor Consultation App";
            Console.WriteLine("Doctor Consultation App");

            ViewModel myViewModel = new ViewModel();

            bool displayMenu = true;
            while (displayMenu == true)
            {
                Console.WriteLine(" ");
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
