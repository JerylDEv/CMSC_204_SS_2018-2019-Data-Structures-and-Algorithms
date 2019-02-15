using Arrays_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Console_App
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

            Console.Title = "Self-Assessment 1 - Arrays";

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
            Console.WriteLine(" ");
            Console.Write("Operation selected: \t");
            string optionSelected = Console.ReadLine();

            // Create an object instance of the ArraysProcedures Class;
            ArraysProcedures arraysProcedures = new ArraysProcedures();

            if (optionSelected == "1")
            {
                arraysProcedures.ReverseArray(array);
                return true;
            }
            else if (optionSelected == "2")
            {
                arraysProcedures.MergeAndSortArray(array);
                return true;
            }
            else if (optionSelected == "3")
            {
                arraysProcedures.InsertElement(array);
                return true;
            }
            else if (optionSelected == "4")
            {
                arraysProcedures.FindAndDeleteMinimumElement(array);
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


       
    }
}
