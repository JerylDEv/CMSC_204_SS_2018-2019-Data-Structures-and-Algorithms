using System;

namespace Self_Assessment_1___Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Self-Assessment Questions

      1. Write a procedure for reversing the elements of an array.
      2. Write a procedure for merging two sorted arrays into one.
      3. Formulate an algorithm for inserting a new element x into a sorted array A
      of size n.
      4. Write a procedure for finding the minimum in an array and deleting it from
      the array.
       */

      int[] numbersList = { 2, 64, 8, 32, 4, 16, 128, 512, 256 };
      Console.Write("The array: \t");
      foreach (int number in numbersList)
      {
        Console.Write(number);
        Console.Write(" ");
      }
      Console.ReadLine();

      Console.Write("The reverse of the array: \t");
      Array.Reverse(numbersList);
      foreach (int number in numbersList)
      {
        Console.Write(number);
        Console.Write(" ");
      }
      Console.ReadLine();

      Console.Write("The sorted array: \t");
      Array.Sort(numbersList);
      foreach (int number in numbersList)
      {
        Console.Write(number);
        Console.Write(" ");
      }


      Console.ReadLine();
    }
  }
}
