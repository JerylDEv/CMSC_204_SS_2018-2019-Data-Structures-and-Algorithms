using System;

namespace _9___Working_with_strings
{
  class Program
  {
    static void Main(string[] args)
    {
      string myStringExample1 = "My \"Awesome\" Family";
      Console.WriteLine(myStringExample1);

      string myStringExample2 = "This shows a \nnew line";
      Console.WriteLine(myStringExample2);

      string myStringExample3 = "Go to c:\\ drive";
      Console.WriteLine(myStringExample3);

      string myStringExample4 = @"Go to c:\ drive";
      Console.WriteLine(myStringExample4);

      string myStringExample5 = String.Format("{0} {1}", "First", "Second");
      Console.WriteLine(myStringExample5);

      string myStringExample6 = String.Format("{0} {0}", "First", "Second");
      Console.WriteLine(myStringExample6);

      string myStringExample7 = String.Format("{1} {0}", "First", "Second");
      Console.WriteLine(myStringExample7);

      //  Currency format
      string myStringExample8 = String.Format("{0:C}", 1000000);
      Console.WriteLine(myStringExample8);

      // Number format
      string myStringExample9 = String.Format("{0:N}", 123456789);
      Console.WriteLine(myStringExample9);

      // Percentage format
      string myStringExample10 = String.Format("{0:P}", 99.99);
      Console.WriteLine(myStringExample10);

      // Custom format
      string myStringExample11 = String.Format("Phone number: {0:(##)-(###)(#######)}", 639164941834);
      Console.WriteLine(myStringExample11);

      string myStringExample12 = " Happy Birthday to you! Happy Birthday ~ Happy Birthday ~ Happy Birthday to you!";


      Console.ReadLine();
    }
  }
}

// Pause at 3:45