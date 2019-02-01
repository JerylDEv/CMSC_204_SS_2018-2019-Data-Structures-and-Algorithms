using System;

namespace _8___while_iteration_statement
{
  class Program
  {
    static void Main(string[] args)
    {
      bool displayMenu = true;

      while (displayMenu)
      {
        displayMenu = MainMenu();
      }

    }

    private static bool MainMenu() // Have the MainMenu() return a bool
    {
      Console.Clear();
      Console.WriteLine("Choose an option: ");
      Console.WriteLine("1) Print numbers");
      Console.WriteLine("2) Guessing game");
      Console.WriteLine("3) Exit");
      string optionSelected = Console.ReadLine();

      if (optionSelected == "1")
      {
        PrintNumbers();
        return true;
      }
      else if (optionSelected == "2")
      {
        GuessingGame();
        return true;
      }
      else if (optionSelected == "3")
      {
        return false;
      }
      else
      {
        return true;
      }

    }

    private static void PrintNumbers()
    {
      Console.Clear();
      Console.WriteLine("Print numbers");
      Console.Write("Type a number: ");
      int numInput = int.Parse(Console.ReadLine());

      int counter = 1;

      while (counter < numInput + 1)
      {
        Console.Write(counter);
        Console.Write("-");
        counter++;
      }

      Console.ReadLine();
    }

    private static void GuessingGame()
    {
      Console.Clear();
      Console.WriteLine("Guessing game");

      Random myRandom = new Random();
      int randomNumber = myRandom.Next(1, 11);
      int guesses = 0;
      bool incorrect = true;

      do
      {
        Console.Write("Guess a number between 1 and 10: ");
        string numberInput = Console.ReadLine();
        guesses++; // Add one to the number of guesses

        if (numberInput == randomNumber.ToString())
        {
          Console.WriteLine($"You guessed it right after {guesses} guesses!");
          incorrect = false;
        }
        else
        {
          Console.WriteLine("Try again.");
        }

      } while (incorrect);


      Console.ReadLine();
    }
  }
}

// Completed at 3:33