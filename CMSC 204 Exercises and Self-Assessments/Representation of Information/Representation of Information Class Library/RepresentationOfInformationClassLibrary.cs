using System;

namespace Representation_of_Information_Class_Library
{
  public class RepresentationOfInformationClassLibrary
  {
    public void DecimalToBinary(int number)
    {
      string binaryString = "";

      while (number != 0)
      {
        if (number % 2 == 0)
        {
          binaryString = binaryString + "0";
        }
        else
        {
          binaryString = binaryString + "1";
        }
        number = number / 2;
      }
      char[] binaryCharArray = binaryString.ToCharArray();
      Array.Reverse(binaryCharArray);
      string binaryCharString = new string(binaryCharArray);
      Console.WriteLine(binaryCharString);
    }
  }
}
