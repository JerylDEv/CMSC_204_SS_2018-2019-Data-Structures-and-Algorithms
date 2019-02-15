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

    public void SequentialSearch(double[] arrayInput, double number)
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

      foreach (double element in arrayInput)
      {
        if (element == number) // True
        {
          Console.WriteLine($"Number {number} matches element {element} inside the array."); // True

        }
        else
        {
          Console.WriteLine($"Number {number} does not match element {element} inside the array."); // False
        }
      }
    }

    public void BinarySearch(double[] arrayInput, double number)
    {
      /*
       *
       *
       *
       *
       *
       *
       */
    }
  }


}
