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

    /*
     *  For One Dimensional Arrays:
     *  1. Sequential Search
     *  2. Binary Search
     *
     *  For Two Dimensional Arrays:
     *  1. Two Dimensional Array Search
     */
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

    public void TwoDimensionalArrayDisplay(int[,] arrayInput)
    {

      Console.WriteLine("Multidimensional Arrays");
      Console.WriteLine(" ");
      // Get the dimensions of the multidimensional array
      int dimensions = arrayInput.Rank;
      Console.WriteLine($"Dimensions of the Array: {dimensions}");
      for (int i = 0; i < dimensions; i++)
      {
        Console.WriteLine($"\tDimension {i}: from {arrayInput.GetLowerBound(i)} to {arrayInput.GetUpperBound(i)}");
      }
      Console.WriteLine(" ");

      // Iterate the 2-dimensional array and display its values
      Console.WriteLine("Values of array elements:");
      for (int outer = arrayInput.GetLowerBound(0); outer <= arrayInput.GetUpperBound(0); outer++)
      {
        for (int inner = arrayInput.GetLowerBound(1); inner <= arrayInput.GetUpperBound(1); inner++)
        {
          Console.WriteLine($"\t{{{outer}, {inner}}} = {arrayInput.GetValue(outer, inner)}");
        }
      }
    }

    public void TwoDimensionalArraySearch(int[,] arrayInput, int number)
    {
      Console.WriteLine("Multidimensional Array Search");
      Console.WriteLine(" ");
      var rowLowerLimit = arrayInput.GetLowerBound(0);
      var rowUpperLimit = arrayInput.GetUpperBound(0);

      var columnLowerLimit = arrayInput.GetLowerBound(1);
      var columnUpperLimit = arrayInput.GetUpperBound(1);

      /*
       *  SearchA2DArray(M,x)
       *  begin
       *    found = FALSE
       *    for i = 1 to n do
       *      for j = 1 to n do
       *        if A[i,j] = x then found = TRUE
       *    return(found)
       *  end
       */
      int currentNumber = 0;
      for (int row = rowLowerLimit; row <= rowUpperLimit; row++)
      {
        for (int column = columnLowerLimit; column <= columnUpperLimit; column++)
        {
          currentNumber = (int)arrayInput.GetValue(row, column);
          if (number == currentNumber)
          {
            Console.WriteLine($"Number {currentNumber} is at position {{{row}, {column}}}");
          }
        }
      }
      if (number != currentNumber)
      {
        Console.WriteLine("Number not found.");
      }
    }
  }
}
