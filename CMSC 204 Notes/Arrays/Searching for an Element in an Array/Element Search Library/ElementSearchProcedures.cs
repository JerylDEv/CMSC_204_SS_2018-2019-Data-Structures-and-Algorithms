using System;

namespace Element_Search_Library
{
  public class ElementSearchProcedures
  {
    public void Hello()
    {
      Console.WriteLine("Hello Mommy Cakes");

      Console.ReadLine();
    }

    public void SequentialSearch(int[] arrayInput, int number)
    {
      /*
       * SequentialSearch(A,x)
       * begin
       *    ptr = 0;
       *    repeat
       *        ptr = ptr + 1;
       *    until (A[ptr] = x) or (ptr = n);
       *    if (A[ptr] = x) return(TRUE)
       *    else return(FALSE)
       * end
       */

      for (int ptr = 0; ptr < arrayInput.Length; ptr++)
      {
        if (arrayInput[ptr] == number) // True
        {
          Console.WriteLine($"Number {number} matches element {arrayInput[ptr]} inside the array."); // True
        }
        else
        {
          Console.WriteLine($"Number {number} does not match element {arrayInput[ptr]} inside the array."); // False
        }
      }
    }

    public void BinarySearch(int[] arrayInput, int number)
    {
      // Binary Search requires a sorted Array thus I'm adding this code to ensure that the array is indeed sorted.
      Array.Sort(arrayInput);

      /*
       * BinarySearch(A,x)
       * begin
       *    lower = 1;
       *    upper = n;
       *    repeat
       *        middle = (lower + upper) div 2;
       *        if x > A[middle] lower = middle + 1;
       *          else upper = middle - 1;
       *    until (A[middle]=x) or (lower > upper);
       *    if (A[middle] = x) return(TRUE)
       *    else return(FALSE)
       * end
       */

      int lower = 0;
      int upper = arrayInput.Length - 1;
      do
      {
        int middle = (lower + upper) / 2;
        if (number > arrayInput[middle])
        {
          lower = middle + 1;
        }
        else
        {
          upper = middle - 1;
        }
        if (arrayInput[middle] == number)
        {
          Console.WriteLine($"Number {arrayInput[middle].ToString()} is at position {middle + 1}.");
        }
        else
        {
          Console.WriteLine("Number not found.");
        }
      } while (lower <= upper);

    }

  }


}
