using System;
using System.Text;

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

      myStringExample12 = myStringExample12.Substring(24, 33);
      Console.WriteLine(myStringExample12);

      myStringExample12 = myStringExample12.ToUpper();
      Console.WriteLine(myStringExample12);

      myStringExample12 = myStringExample12.ToLower();
      Console.WriteLine(myStringExample12);

      myStringExample12 = myStringExample12.Replace(" ", "--");
      Console.WriteLine(myStringExample12);

      myStringExample12 = myStringExample12.Remove(0, 17);
      Console.WriteLine(myStringExample12);

      myStringExample12 = " ~--happy--birthday--~  ";
      myStringExample12 = String.Format("Length before {0} -- Length after: {1}", myStringExample12.Length, myStringExample12.Trim().Length);
      Console.WriteLine(myStringExample12);

      string myStringExample13 = "";
      for (int i = 0; i < 100; i++)
      {
        myStringExample13 += "--" + i.ToString();
      }
      Console.WriteLine(myStringExample13);

      // A string is an immutable data type. This means that we can't just add values to it, what happens is that behind the scenes the dotnet runtime is performing to make it look like we are working with the original myStringExample13.
      // But what it does is it creates a second bucket and it starts copying the previous values of the bucket, plus any values we want to put in there. And then it creates a new string and a new bucket, removes the previous bucket, and renames the new bucket myStringExample13. This process happens a couple of times because of the number of the loop.
      // This is an inefficient way and will require the runtime a lot of the memory management that could drain the system.
      // To address this, we could use a StringBuilder instead.

      StringBuilder myStringExample14 = new StringBuilder();
      for (int i = 0; i < 100; i++)
      {
        myStringExample14.Append("--");
        myStringExample14.Append(i);
      }
      Console.WriteLine(myStringExample14);

      Console.ReadLine();
    }
  }
}

// Pause at 3:45