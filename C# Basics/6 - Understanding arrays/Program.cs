using System;

namespace _6___Understanding_arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      // Arrays
      int[] numbers = new int[5];
      numbers[0] = 4;
      numbers[1] = 8;
      numbers[2] = 16;
      numbers[3] = 32;
      numbers[4] = 64;

      for (int i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine($"Array element {i} contains {numbers[i]}");
      }

      Console.ReadLine();
    }
  }
}
