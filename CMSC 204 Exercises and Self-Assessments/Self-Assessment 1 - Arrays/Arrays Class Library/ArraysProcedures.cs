using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Class_Library
{
    public class ArraysProcedures
    {
        public void ReverseArray(double[] arrayInput)
        {
            Console.Clear();

            Console.WriteLine($"This is your array: \t{arrayInput[0]} {arrayInput[1]} {arrayInput[2]} {arrayInput[3]} {arrayInput[4]}");
            Console.WriteLine(" ");

            /* I copied the elements of the arrayInput to the new copied Array so that I could not permanently effect changes to the original arrayInput */
            double[] copiedArray = new double[arrayInput.Length];
            arrayInput.CopyTo(copiedArray, 0);

            /* Code to reverse the array */
            Array.Reverse(copiedArray);

            Console.Write("Reversed your array: \t");
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

        public void MergeAndSortArray(double[] arrayInput)
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

        public void InsertElement(double[] arrayInput)
        {
            Console.Clear();

            Console.WriteLine($"This is your array: \t{arrayInput[0]} {arrayInput[1]} {arrayInput[2]} {arrayInput[3]} {arrayInput[4]}");
            Console.WriteLine(" ");

            /* I copied the elements of the arrayInput to the new copied Array so that I could not permanently effect changes to the original arrayInput */
            double[] copiedArray = new double[arrayInput.Length];
            arrayInput.CopyTo(copiedArray, 0);

            // Console.Write("Enter a number: ");
            // double numberInput = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(" ");

            double numberInputTypeDouble = 0;
            bool validNumber = false;

            /* Validate if number input can be converted into type Double */
            while (!validNumber) // while not a valid number
            {
                Console.Write("Enter a number: "); // ask for a number
                string input = Console.ReadLine(); // read the input number as a string first
                if (double.TryParse(input, out numberInputTypeDouble) == false) // try to convert the string input in to type double, and if it results to false
                {
                    Console.WriteLine("Please enter a number."); // ask for a number again.
                }
                else
                {
                    validNumber = true; // otherwise, end the loop.
                }
            }


            /* Resize the copiedArray to increase its size by 1 */
            Array.Resize(ref copiedArray, copiedArray.Length + 1);

            /* Add the number input into the last index in the newly resized copiedArray */
            copiedArray[copiedArray.Length - 1] = numberInputTypeDouble;

            /* Sort the copiedArray */
            Array.Sort(copiedArray);

            Console.WriteLine(" ");
            Console.Write("Resized and sorted the array with your number input: \t");
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

        public void FindAndDeleteMinimumElement(double[] arrayInput)
        {
            Console.Clear();

            Console.WriteLine($"This is your array: \t{arrayInput[0]} {arrayInput[1]} {arrayInput[2]} {arrayInput[3]} {arrayInput[4]}");
            Console.WriteLine(" ");

            /* I copied the elements of the arrayInput to the new copied Array so that I could not permanently effect changes to the original arrayInput */
            double[] copiedArray = new double[arrayInput.Length];
            arrayInput.CopyTo(copiedArray, 0);

            Array.Sort(copiedArray); // Sort the copiedArray to isolate the minimum number at index 0.
            double minNumber = copiedArray[0]; // assign the minimum number in to a variable of double type.

            /* I created another copy of the arrayInput to have another array that isn't sorted yet. */
            double[] copiedArrayNotSorted = new double[arrayInput.Length];
            arrayInput.CopyTo(copiedArrayNotSorted, 0);

            copiedArrayNotSorted = copiedArrayNotSorted.Where((number) => number != minNumber).ToArray(); // created a Linq query to filter out the minimum number from the arrayInput.

            // Console.WriteLine(arrayInput.Length); I noticed that this resulted to 4 meaning the Linq query I made automatically resized the arrayInput.

            Console.Write("This is your array without the minimum number: \t");
            foreach (int number in copiedArrayNotSorted)
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
