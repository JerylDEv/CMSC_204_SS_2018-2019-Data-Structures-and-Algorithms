using System;
using Multidimensional_Arrays_Class_Library;

namespace Multidimensional_Arrays_Console_App
{
  class Program
  {
    static void Main(string[] args)
    {
      MultidimensionalArraysClassLibrary multidimensionalArray = new MultidimensionalArraysClassLibrary();
      multidimensionalArray.Hello();

      int number = 69;
      string binaryString = "";

      while (number != 0)
      {
        if (number % 2 == 0)
        {
          binaryString = binaryString + "0";
        }
        else
        {
          binaryString = binaryString + "1";
        }
        number = number / 2;
      }
      binaryString.

      Console.ReadLine();
    }
  }
}
