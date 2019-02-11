using System;

namespace _14___Understanding_namespaces_and_working_with_.NET_Class_Library
{
  class Program
  {
    static void Main(string[] args)
    {
      /* 
      We could use the full name of Classes in our application. However, we didn't have to add System since we used a "using" statement it at the very outset of this code file. With the "using" statement we are basically instructs to look in to the Classes of the Namespace identified.
      */
      System.Console.WriteLine("Hello World!");

      Console.ReadLine();
    }
  }
}
/*
Namespaces

In a few cases, the same class name was used or there is a potential for it to be used again and so when that happen the creators needed a way to be able to tell one class from a different class and so the Developers introduced namespaces.
Namespaces are like last names for the .NET Framework Classes.
 */
