using System;

namespace Exercise_0___A_Simple_Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "A Simple Calculator";

      bool displayCalculator = true;

      while (displayCalculator)
      {
        displayCalculator = Calculator();
      }
    }

    private static bool Calculator()
    {
      Console.Clear();

      // Accept user input
      Console.Write("Enter a number: ");
      double firstNumber = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter another number: ");
      double secondNumber = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("");

      DisplayResult(firstNumber, secondNumber);

      Console.ReadLine();

      // Try again?
      Console.WriteLine("Do you want to try again?");
      Console.WriteLine("1) Yes");
      Console.WriteLine("2) No / Exit");
      string optionSelected = Console.ReadLine();

      if (optionSelected == "1")
      {
        return true;
      }
      else if (optionSelected == "2")
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    private static void DisplayResult(double num1, double num2)
    {
      // Declare and create an instance of the Calculate Class which contains all the calculation methods
      Calculate calculate = new Calculate();

      // Display the results
      Console.WriteLine("Here are the results ...");

      Console.WriteLine(" ");

      // Sum
      Console.WriteLine($"Sum:\t{num1} + {num2} = {calculate.Addition(num1, num2)}");

      // Difference
      Console.WriteLine($"Difference:\t{num1} - {num2} = {calculate.Subtraction(num1, num2)}");

      // Product
      Console.WriteLine($"Product:\t{num1} * {num2} = {calculate.Multiplication(num1, num2)}");

      // Quotient
      Console.WriteLine($"Quotient:\t{num1} / {num2} = {calculate.Division(num1, num2)}");
    }

  }
  class Calculate
  {
    // Perform the calculation
    public double Addition(double number1, double number2)
    {
      // Addition
      double sum = number1 + number2;
      return sum;
    }

    public double Subtraction(double number1, double number2)
    {
      // Subtraction
      double difference = number1 - number2;
      return difference;
    }

    public double Multiplication(double number1, double number2)
    {
      // Multiplication
      double product = number1 * number2;
      return product;
    }

    public double Division(double number1, double number2)
    {
      // Division
      double quotient = number1 / number2;
      return quotient;
    }
  }
}
