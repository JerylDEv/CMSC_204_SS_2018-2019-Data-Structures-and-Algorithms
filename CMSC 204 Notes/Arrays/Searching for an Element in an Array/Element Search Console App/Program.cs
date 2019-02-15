using Element_Search_Library;
using System;

namespace Element_Search_Console_App
{
  class Program
  {
    static void Main(string[] args)
    {
      ElementSearchProcedures search = new ElementSearchProcedures();
      search.Hello();

      int[] numbersList = new int[10] { 1, 3, 5, 7, 200, 13, 17, 19, 23, 31 };
      int findTest1 = 19;
      //int findTest2 = 12;

      // Important: Sequential Search works in both sorted and unsorted data.
      search.SequentialSearch(numbersList, findTest1);
      Console.WriteLine(" ");

      // Important: Binary Search works only in sorted data.
      Array.Sort(numbersList);
      search.BinarySearch(numbersList, findTest1);
      Console.WriteLine(" ");


      Console.ReadLine();

    }
  }
}
