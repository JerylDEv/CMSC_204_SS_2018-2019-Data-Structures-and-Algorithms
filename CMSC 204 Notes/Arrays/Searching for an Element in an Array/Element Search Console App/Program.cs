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

      // Important: Binary Search works only in sorted data. Note that the sorting happens within the Binary Search method
      search.BinarySearch(numbersList, findTest1);
      Console.WriteLine(" ");

      /*
       * Observations:
       * Binary Search requires data to be sorted in order for it to work properly.
       * Binary Search is way faster that Sequential Search.
       * I think if the data can be sorted (let's say in an ascending manner) then we can use Binary Search for effective searching.
       */


      Console.ReadLine();

    }
  }
}
