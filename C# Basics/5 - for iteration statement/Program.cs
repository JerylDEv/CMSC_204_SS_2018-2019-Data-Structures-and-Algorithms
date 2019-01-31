using System;

namespace _5___for_iteration_statement
{
  class Program
  {
    static void Main(string[] args)
    {
      // for iteration statement
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
        if (i == 7)
        {
          Console.WriteLine("Found seven!");
          break;
        }
      }
      Console.ReadLine();

    }
  }
}
