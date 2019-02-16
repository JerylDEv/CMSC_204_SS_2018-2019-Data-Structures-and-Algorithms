using Element_Search_Library;
using System;

namespace Element_Search_Console_App
{
  class Program
  {
    static void Main(string[] args)
    {
      OneDimensionalArray();

      MultiDimensionalArray();

      Console.ReadLine();
    }

    private static void OneDimensionalArray()
    {
      ElementSearchProcedures search = new ElementSearchProcedures();
      // Element_Search_Library Test
      // search.Hello();


      int[] numbersList = new int[10] { 1, 3, 5, 7, 200, 13, 17, 19, 23, 31 };
      int findTest1 = 19;
      //int findTest2 = 12;

      Console.WriteLine("Sequential Search");
      Console.WriteLine(" ");

      // Important: Sequential Search works in both sorted and unsorted data.
      search.SequentialSearch(numbersList, findTest1);
      Console.WriteLine(" ");

      Console.WriteLine("Binary Search");
      Console.WriteLine(" ");

      // Important: Binary Search works only in sorted data. Note that the sorting happens within the Binary Search method which I created.
      search.BinarySearch(numbersList, findTest1);
      Console.WriteLine(" ");

      /*
       * Observations:
       * Binary Search requires data to be sorted in order for it to work properly.
       * Binary Search is way faster that Sequential Search. This is evidenced by how many lines I was able to produce for Sequential Search vs Binary Search.
       * I think if the data can be sorted (let's say in an ascending manner) then we can use Binary Search for effective searching.
       */
    }

    private static void MultiDimensionalArray()
    {
      int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

      Console.WriteLine(numbers[0, 0]);
      Console.WriteLine(numbers[0, 1]);
      Console.WriteLine(numbers[1, 0]);
      Console.WriteLine(numbers[1, 1]);
      Console.WriteLine(numbers[2, 0]);
      Console.WriteLine(numbers[2, 1]);

      var allLength = numbers.Length;
      var total = 1;
      for (int i = 0; i < numbers.Rank; i++)
      {
        total *= numbers.GetLength(i);
      }

      Console.WriteLine($"allLength of {allLength} equals total {total}");
    }
  }
}
