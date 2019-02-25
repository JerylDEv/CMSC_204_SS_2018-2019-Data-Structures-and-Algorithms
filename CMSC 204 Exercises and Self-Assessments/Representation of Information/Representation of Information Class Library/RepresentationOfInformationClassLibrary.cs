using System;
using System.Linq;
using System.Text;

namespace Representation_of_Information_Class_Library
{
  public class RepresentationOfInformationClassLibrary
  {
    public string DecimalToBinary(string inputString)
    {
      int decimalInput = Convert.ToInt32(inputString);
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
      return binaryCharString;
    }

    public string BinaryToHexadecimal(string binaryInput)
    {
      string hexadecimalString = Convert.ToInt32(binaryInput, 2).ToString("X");
      return hexadecimalString;
    }

    public string BinaryToDecimal(string binaryInput)
    {
      // int rem, num, decimal_val = 0, base_val = 0;
      // int binaryNumber = Convert.ToInt32(binaryInput);
      // while (binaryNumber > 0)
      // {
      //   rem = binaryNumber % 10;
      //   decimal_val = decimal_val + rem * base_val;
      //   num = binaryNumber / 10;
      //   base_val = base_val * 2;
      // }

      int dec = Convert.ToInt32(binaryInput, 2);
      return dec.ToString();
    }

    public string HexadecimalToDecimal(string hexadecimalInput)
    {
      Decimal dec = long.Parse(hexadecimalInput, System.Globalization.NumberStyles.HexNumber);
      return dec.ToString();
    }
  }
}
