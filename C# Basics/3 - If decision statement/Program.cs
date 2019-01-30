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
            string message = "";

            if (userValue == "1")
            {
                message = "You won a house and lot!";
            }
            else if (userValue == "2")
            {
                message = "You won a car!";
            }
            else if (userValue == "3")
            {
                message = "You won 1,000,000 pesos!";
            }
            else
            {
                message = "Sorry, we cannot find the number.";
            }

            Console.WriteLine(message);

            Console.ReadLine();

        }
    }
}
