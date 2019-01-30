using System;

namespace _3___If_decision_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeryl's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "You won a house and lot!";
                Console.WriteLine(message);
            }
            Console.ReadLine();

        }
    }
}
