using System;

namespace _2___Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            int x, y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
             */

            Console.Title = "Storing Values";

            char letter; letter = 'a'; // Declared then initialized
            int number; number = 100; // Declared then initialized
            float body = 98.6f; // Declared and initialized
            double pi = 3.14159; // Declared and initialized
            decimal kilometer = 1000.00m; // Declared and initialized
            bool flag = false; // Declared and initialized
            string text = "C# is fun"; // Declared and initialized

            Console.WriteLine("Variables:");
            Console.WriteLine("");
            Console.WriteLine($"char letter:\t{letter}");
            Console.WriteLine($"int number:\t{number}");
            Console.WriteLine($"float body:\t{body}");
            Console.WriteLine($"double pi:\t{pi}");
            Console.WriteLine($"decimal sum:\t{kilometer}");
            Console.WriteLine($"bool flag:\t{flag}");
            Console.WriteLine($"string flag:\t{text}");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Input:");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Write("Type your first name: ");
            // Declaring and Initializing the Variable
            string myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine($"Hello, {myFirstName} {myLastName}");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Conversion:");
            Console.WriteLine("");
            Console.Write("Please enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine($"Sum Total = {sum}");
            Console.ReadKey();

        }
    }
}

// Continue to 1:25