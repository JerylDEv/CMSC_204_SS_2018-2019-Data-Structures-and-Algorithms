using System;
using Representation_of_Information_Class_Library;

namespace Representation_of_Information_Console_Application
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      RepresentationOfInformationClassLibrary representation = new RepresentationOfInformationClassLibrary();
      Console.Write("Enter a Number: \t");
      int numberInput = Convert.ToInt32(Console.ReadLine());
      representation.DecimalToBinary(numberInput);


      Console.ReadLine();
    }
  }
}
