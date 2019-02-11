using System;
using System.Linq;

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

      Console.Title = "Self-Assessment Numbers Array";

      double[] numbersList = new double[5];

      int items = 0;

      Console.WriteLine("Enter 5 numbers: ");

      while (items < 5)
      {
        if (double.TryParse(Console.ReadLine(), out numbersList[items]))
        {
          items++;
        }
        else
        {
          Console.WriteLine("Please enter a number.");
        }
      }

      Console.Write(" ");

      Console.WriteLine($"This is your array of 5 numbers: \t{numbersList[0]} {numbersList[1]} {numbersList[2]} {numbersList[3]} {numbersList[4]}");

      Console.WriteLine(" ");

      bool displayOptions = true;
      while (displayOptions)
      {
        displayOptions = Options(numbersList);
      }
    }

    private static bool Options(double[] array)
    {
      Console.WriteLine("Select an operation to perform:");
      Console.WriteLine("1) Reverse the array");
      Console.WriteLine("2) Merge two sorted arrays");
      Console.WriteLine("3) Insert an element into the array");
      Console.WriteLine("4) Find the minimum in the array and delete it");
      Console.WriteLine("5) Exit");
      string optionSelected = Console.ReadLine();


      if (optionSelected == "1")
      {
        ReverseArray(array);
        return true;
      }
      else if (optionSelected == "2")
      {
        MergeAndSortArray(array);
        return true;
      }
      else if (optionSelected == "3")
      {
        InsertElement(array);
        return true;
      }
      else if (optionSelected == "4")
      {
        FindAndDeleteMinimumElement(array);
        return true;
      }
      else if (optionSelected == "5")
      {
        return false;
      }
      else
      {
        return true;
      }
    }


    private static void ReverseArray(double[] arrayInput)
    {
      Console.Clear();

      Console.WriteLine($"This is your array: \t{arrayInput[0]} {arrayInput[1]} {arrayInput[2]} {arrayInput[3]} {arrayInput[4]}");
      Console.WriteLine(" ");

      /* I copied the elements of the arrayInput to the new copied Array so that I could not permanently effect changes to the original arrayInput */
      double[] copiedArray = new double[arrayInput.Length];
      arrayInput.CopyTo(copiedArray, 0);

      /* Code to reverse the array */
      Array.Reverse(copiedArray);

      Console.Write("This is the reversal of your array: \t");
      foreach (int number in copiedArray)
      {
        Console.Write(number);
        Console.Write(" ");
      }
      Console.WriteLine(" ");

      Console.WriteLine(" ");
      Console.WriteLine("Press Enter to go back to the Main Menu.");
      Console.WriteLine(" ");

      Console.ReadLine();
    }

    private static void MergeAndSortArray(double[] arrayInput)
    {
      Console.Clear();

      Console.WriteLine($"This is your array: \t{arrayInput[0]} {arrayInput[1]} {arrayInput[2]} {arrayInput[3]} {arrayInput[4]}");
      Console.WriteLine(" ");

      /* I copied the elements of the arrayInput to the new copied Array so that I could not permanently effect changes to the original arrayInput */
      double[] copiedArray = new double[arrayInput.Length];
      arrayInput.CopyTo(copiedArray, 0);

      /* Another sorted array */
      double[] anotherSortedArray = new double[] { 2, 24, 38, 416, 532 };

      /* Merge the two arrays */
      double[] mergedArray = new double[copiedArray.Length + anotherSortedArray.Length];
      copiedArray.CopyTo(mergedArray, 0); // copiedArray elements will be copied to the first 5 indexes of the separate array called mergedArray.
      anotherSortedArray.CopyTo(mergedArray, copiedArray.Length); // anotherSortedArray elements will be copied to the indexes of the mergedArray after the copiedArray elements.

      /* Code to sort the arrays */
      Array.Sort(mergedArray);

      Console.WriteLine("Another sorted array: \t2 24 38 416 532");
      Console.WriteLine(" ");
      Console.Write("Merged and sorted the two arrays: \t");
      foreach (int number in mergedArray)
      {
        Console.Write(number);
        Console.Write(" ");
      }
      Console.WriteLine(" ");

      Console.WriteLine(" ");
      Console.WriteLine("Press Enter to go back to the Main Menu.");
      Console.WriteLine(" ");

      Console.ReadLine();
    }

    private static void InsertElement(double[] arrayInput)
    {
      Console.Clear();

      Console.WriteLine($"This is your array: \t{arrayInput[0]} {arrayInput[1]} {arrayInput[2]} {arrayInput[3]} {arrayInput[4]}");
      Console.WriteLine(" ");

      /* I copied the elements of the arrayInput to the new copied Array so that I could not permanently effect changes to the original arrayInput */
      double[] copiedArray = new double[arrayInput.Length];
      arrayInput.CopyTo(copiedArray, 0);

      Console.Write("Enter a number: ");
      double numberInput = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(" ");

      /* Resize the copiedArray to increase its size by 1 */
      Array.Resize(ref copiedArray, copiedArray.Length + 1);

      /* Add the number input into the last index in the newly resized copiedArray */
      copiedArray[copiedArray.Length - 1] = numberInput;

      /* Sort the copiedArray */
      Array.Sort(copiedArray);

      Console.Write("Resized and sorted array with your number input: \t");
      foreach (int number in copiedArray)
      {
        Console.Write(number);
        Console.Write(" ");
      }
      Console.WriteLine(" ");

      Console.WriteLine(" ");
      Console.WriteLine("Press Enter to go back to the Main Menu.");
      Console.WriteLine(" ");

      Console.ReadLine();
    }

    private static void FindAndDeleteMinimumElement(double[] arrayInput)
    {
      Console.Clear();

      Console.WriteLine($"This is your array: \t{arrayInput[0]} {arrayInput[1]} {arrayInput[2]} {arrayInput[3]} {arrayInput[4]}");
      Console.WriteLine(" ");

      /* I copied the elements of the arrayInput to the new copied Array so that I could not permanently effect changes to the original arrayInput */
      double[] copiedArray = new double[arrayInput.Length];
      arrayInput.CopyTo(copiedArray, 0);

      Array.Sort(copiedArray); // Sort the copiedArray to isolate the minimum number at index 0.
      double minNumber = copiedArray[0]; // assign the minimum number in to a variable of double type.
      copiedArray = copiedArray.Where((number) => number != minNumber).ToArray(); // created a Linq query to filter out the minimum number from the arrayInput.

      // Console.WriteLine(arrayInput.Length); I noticed that this resulted to 4 meaning the Linq query I made automatically resized the arrayInput.

      Console.Write("This is your array without the minimum number: \t");
      foreach (int number in copiedArray)
      {
        Console.Write(number);
        Console.Write(" ");
      }
      Console.WriteLine(" ");

      Console.WriteLine(" ");
      Console.WriteLine("Press Enter to go back to the Main Menu.");
      Console.WriteLine(" ");

      Console.ReadLine();
    }
  }
}
