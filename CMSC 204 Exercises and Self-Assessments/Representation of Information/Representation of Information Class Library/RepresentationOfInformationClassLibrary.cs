using System;

namespace Representation_of_Information_Class_Library
{
  public class RepresentationOfInformationClassLibrary
  {
    public int DecimalToBinary(int decimalInput)
    {
      string binaryString = "";

      while (decimalInput != 0)
      {
        if (decimalInput % 2 == 0)
        {
          binaryString = binaryString + "0";
        }
        else
        {
          binaryString = binaryString + "1";
        }
        decimalInput = decimalInput / 2;
      }
      char[] binaryCharArray = binaryString.ToCharArray();
      Array.Reverse(binaryCharArray);
      string binaryCharString = new string(binaryCharArray);
      // Console.WriteLine(binaryCharString);
      return Convert.ToInt32(binaryCharString);
    }



    public void BinaryToHexadecimal(int binaryInput)
    {

    }
  }
}
