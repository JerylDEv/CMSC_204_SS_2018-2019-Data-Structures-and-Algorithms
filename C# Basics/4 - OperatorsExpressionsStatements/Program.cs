using System;

namespace _4___OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // An Expression is a combination of operands and operators. We use expressions to form complete thoughts or Statements. Statements are how the actions or the instructions of the applications are expressed to the compiler and ultimately to the .net runtime which executes the application.

            // Variable declaration
            int x, y, a, b;

            // Assignment operator
            x = 1;
            y = 2;
            a = 3;
            b = 4;

            // Mathematical operators

            // Addition
            x = 10 + 5;

            // Subtraction
            y = 10 - 5;

            // Multiplication
            a = 10 * 3;

            // Division
            b = 20 / 4;

            // Order of operations using parenthesis
            x = (x + y) * (a - b);

            // There are many operators used to evaluate values ...

            // Equality operator
            if (x == y)
            {

            }

            // Greater than operator
            if (x > y)
            {

            }

            // Less than operator
            if (x < y)
            {

            }

            // Greater than or equal to operator
            if (x >= y)
            {

            }

            // Less than or equal to operator
            if (x <= y)
            {

            }

            // Conditional operators

            // Conditional AND operator
            if ((x == y) && (a == b))
            {

            }

            // Conditional OR operator
            if ((x == y) || (a == b))
            {

            }

            // In-line conditional operator
            string message = (x == 5) ? "X is equal to 5" : "X is not equal to 5";

            // Member access and Method invocation
            // Console is a Class (a container for method)
            // . is the member accessor operator which we use to access a member method of a class
            // () method invocation operator
            // "Hello World" is an input parameter
            Console.WriteLine("Hello World");
        }
    }
}

// Completed at 2:06:52