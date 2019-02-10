using System;

namespace Self_Assessment_1___Reverse_the_elements_of_an_array
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] strSocialArray = { "facebook", "instagram", "twitter" };
      Console.Write("The array: ");
      for (int i = 0; i < strSocialArray.Length; i++)
      {
        Console.Write(strSocialArray[i]);
        Console.Write(" ");
      }

      Console.ReadLine();

      /* This code handles the reversal of the array element positions */
      Array.Reverse(strSocialArray);

      Console.Write("The reverse of the array: ");
      foreach (string social in strSocialArray)
      {
        Console.Write(social);
        Console.Write(" ");
      }

      Console.ReadLine();
    }
  }
}
