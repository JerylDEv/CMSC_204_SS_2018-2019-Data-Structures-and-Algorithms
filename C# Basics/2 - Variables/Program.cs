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

            Console.WriteLine("What is your name? ");
            Console.WriteLine("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.WriteLine("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine($"Hello, {myFirstName} {myLastName}");
            Console.ReadLine();

        }
    }
}
