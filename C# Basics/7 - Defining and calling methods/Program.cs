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


    }

    // Defining and calling method
    // HelloWorld helper method inside the Program class and outside the Main method
    private static void GameName()
    {
      Console.WriteLine("Reverse the name");
    }


  }
}
