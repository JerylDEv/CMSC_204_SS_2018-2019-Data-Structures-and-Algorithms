using System;

namespace Exercise_0___A_Simple_Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "A Simple Calculator";

      // Accept user input
      Console.Write("Enter a number: ");
      double firstNumber = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter another number: ");
      double secondNumber = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("");

      DisplayResult(firstNumber, secondNumber);

      Console.ReadLine();
    }

    // Perform the calculation
    private static double Addition(double number1, double number2)
    {
      // Addition
      double sum = number1 + number2;
      return sum;
    }

    private static double Subtraction(double number1, double number2)
    {
      // Subtraction
      double difference = number1 - number2;
      return difference;
    }

    private static double Multiplication(double number1, double number2)
    {
      // Multiplication
      double product = number1 * number2;
      return product;
    }

    private static double Division(double number1, double number2)
    {
      // Division
      double quotient = number1 / number2;
      return quotient;
    }

    private static void DisplayResult(double num1, double num2)
    {
      // Display the results

      Console.WriteLine("Here are the results ...");

      Console.WriteLine(" ");

      // Sum
      Console.WriteLine($"Sum:\t{num1} + {num2} = {Addition(num1, num2)}");

      // Difference
      Console.WriteLine($"Difference:\t{num1} - {num2} = {Subtraction(num1, num2)}");

      // Product
      Console.WriteLine($"Product:\t{num1} * {num2} = {Multiplication(num1, num2)}");

      // Quotient
      Console.WriteLine($"Quotient:\t{num1} / {num2} = {Division(num1, num2)}");
    }

  }
}
