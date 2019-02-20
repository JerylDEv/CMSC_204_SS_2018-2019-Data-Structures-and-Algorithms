using System;
using Representation_of_Information_Class_Library;

namespace Representation_of_Information_Console_Application
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Representation of Information Console App";
      RepresentationOfInformationClassLibrary representation = new RepresentationOfInformationClassLibrary();
      Console.Write("Enter a Number: \t");

      // Decimal to Binary
      int numberInput = Convert.ToInt32(Console.ReadLine());
      string binaryOutput = Convert.ToString(representation.DecimalToBinary(numberInput));
      Console.WriteLine(" ");
      Console.WriteLine($"Binary: \t{binaryOutput}");

      Console.ReadLine();
    }
  }
}
