using System;
using Representation_of_Information_Class_Library;

namespace Representation_of_Information_Console_Application
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Representation of Information Console App";

      bool displayMenu = true;
      while (displayMenu)
      {
        displayMenu = MenuOptions();
      }
    }

    private static bool MenuOptions()
    {
      Console.WriteLine("Select an operation to perform:");
      Console.WriteLine("1) Decimal conversion");
      Console.WriteLine("2) Binary conversion");
      Console.WriteLine("3) Hexadecimal conversion");
      Console.WriteLine("4) Exit");
      Console.WriteLine(" ");
      Console.Write("Operation selected: \t");
      string operationSelected = Console.ReadLine();

      if (operationSelected == "1")
      {
        DecimalConversion();
        return true;
      }
      else if (operationSelected == "2")
      {
        BinaryConversion();
        return true;
      }
      else if (operationSelected == "3")
      {
        HexadecimalConversion();
        return true;
      }
      else if (operationSelected == "4")
      {
        return false;
      }
      else
      {
        return true;
      }

    }

    private static void DecimalConversion()
    {
      RepresentationOfInformationClassLibrary representation = new RepresentationOfInformationClassLibrary();

      Console.WriteLine(" ");
      Console.Write("Enter a decimal number: \t");
      string input = Console.ReadLine();

      // Decimal to Binary
      string binaryOutput = representation.DecimalToBinary(input);
      Console.WriteLine(" ");
      Console.WriteLine($"Binary: \t{binaryOutput}");

      // Binary to Hexadecimal
      string hexadecimalOutput = representation.BinaryToHexadecimal(binaryOutput);
      Console.WriteLine($"Hexadecimal: \t{hexadecimalOutput}");

      Console.ReadLine();
    }

    private static void BinaryConversion()
    {
      RepresentationOfInformationClassLibrary representation = new RepresentationOfInformationClassLibrary();

      Console.WriteLine(" ");
      Console.Write("Enter a binary number: \t");
      string input = Console.ReadLine();

      // Binary to Hexadecimal
      string hexadecimalOutput = representation.BinaryToHexadecimal(input);
      Console.WriteLine(" ");
      Console.WriteLine($"Hexadecimal: \t{hexadecimalOutput}");

      // Binary to Decimal
      string decimalOutput = representation.BinaryToDecimal(input);
      Console.WriteLine($"Decimal: \t{decimalOutput}");

      Console.ReadLine();
    }

    private static void HexadecimalConversion()
    {
      RepresentationOfInformationClassLibrary representation = new RepresentationOfInformationClassLibrary();

      Console.WriteLine(" ");
      Console.Write("Enter a hexadecimal number: \t");
      string input = Console.ReadLine();

      // Hexadecimal to Decimal
      string decimalOutput = representation.HexadecimalToDecimal(input);
      Console.WriteLine(" ");
      Console.WriteLine($"Decimal: \t{decimalOutput}");

      // Decimal to Binary
      string binaryOutput = representation.DecimalToBinary(decimalOutput);
      Console.WriteLine($"Binary: \t{binaryOutput}");

      Console.ReadLine();
    }
  }
}
