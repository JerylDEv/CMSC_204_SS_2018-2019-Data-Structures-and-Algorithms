using System;

namespace _7___Defining_and_calling_methods
{
  class Program
  {
    static void Main(string[] args)
    {
      // Method invocation
      GameName();

      /* Before
      Console.Write("First Name: ");
      string firstName = Console.ReadLine();

      Console.Write("Last Name: ");
      string lastName = Console.ReadLine();

      string name = $"{firstName} {lastName}";

      char[] nameArray = name.ToCharArray();
      Array.Reverse(nameArray);

      foreach (char element in nameArray)
      {
        Console.Write(element);
      }

      Console.ReadLine();
      */

      /* After */

      Console.Write("First Name: ");
      string firstName = Console.ReadLine();

      Console.Write("Last Name: ");
      string lastName = Console.ReadLine();

      DisplayResult(ReverseString(firstName), ReverseString(lastName));

      Console.WriteLine("");

      DisplayResult($"{ReverseString(firstName)} {ReverseString(lastName)}");

      Console.ReadLine();
    }

    // Defining and calling method
    // HelloWorld helper method inside the Program class and outside the Main method
    private static void GameName()
    {
      Console.WriteLine("Reverse the name");
    }

    private static string ReverseString(string name)
    {
      char[] nameArray = name.ToCharArray();
      Array.Reverse(nameArray);
      return String.Concat(nameArray);
    }

    private static void DisplayResult(string firstName, string lastName)
    {
      Console.Write("Results: ");
      Console.Write(String.Format("{0} {1}",
        firstName,
        lastName));
    }

    // Overloaded version of the DisplayResult method
    private static void DisplayResult(string name)
    {
      Console.Write("Results: ");
      Console.Write(name);
    }
  }
}

// Completed 3:15