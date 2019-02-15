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

      double[] numbersList = { 11, 200, 35, 46, 500 };
      double findTest1 = 200;
      double findTest2 = 12;

      search.SequentialSearch(numbersList, findTest1);
      Console.WriteLine(" ");
      search.SequentialSearch(numbersList, findTest2);

      Console.ReadLine();
    }
  }
}
