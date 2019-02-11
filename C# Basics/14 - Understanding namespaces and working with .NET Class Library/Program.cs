using System;
using System.IO;
using System.Net;

namespace _14___Understanding_namespaces_and_working_with_.NET_Class_Library
{
  class Program
  {
    static void Main(string[] args)
    {
      /* 
      We could use the full name of Classes in our application. However, we didn't have to add System since we used a "using" statement it at the very outset of this code file. 
      With the "using" statement we are basically instructs to look in to the Classes of the Namespace identified.
      To disambiguate our Class with another Class of the same name but from a different Namespace, then we have to set the full name of the Class.
      */
      System.Console.WriteLine("Hello World!");

      // Example #2: Write one string to a text file.
      string text = "A class is the most powerful data type in C#. Like a structure, " + "a class defines the data and behavior of the data type. ";
      // WriteAllText creates a file, writes the specified string to the file,
      // and then closes the file.    You do NOT need to call Flush() or Close().
      // System.IO.File.WriteAllText(@"C:\Users\accessadmin\Documents\2 - UPOU\CMSC 204\C# Basics\14 - Understanding namespaces and working with .NET Class Library\WriteText.txt", text);
      File.WriteAllText(@"C:\Users\accessadmin\Documents\2 - UPOU\CMSC 204\C# Basics\14 - Understanding namespaces and working with .NET Class Library\WriteText.txt", text); // This will create a WriteText.txt file and save it in the specified folder.

      DownloadString("https://jeryldev.com"); // Executing this method will create a new reply.txt file which contains the html contents of the website specified.

      Console.ReadLine();
    }

    public static void DownloadString(string address)
    {
      /*
      Initially, a red squigly line will appear because we may not have an assembly referenced in our project or we may have the assembly reference but we do not have the using statement that contains the WebClient Class. To resolve this, click the "WebClient", press CTRL + . on the keyboard, and then choose "using System.Net;"
      */
      WebClient client = new WebClient();
      string reply = client.DownloadString(address);

      Console.WriteLine(reply);

      File.WriteAllText(@"C:\Users\accessadmin\Documents\2 - UPOU\CMSC 204\C# Basics\14 - Understanding namespaces and working with .NET Class Library\Reply.txt", reply);

    }

  }
}
/*
Namespaces

In a few cases, the same class name was used or there is a potential for it to be used again and so when that happen the creators needed a way to be able to tell one class from a different class and so the Developers introduced namespaces.
Namespaces are like last names for the .NET Framework Classes.
 */

/*
How we could go about using the .NET Framework Class Library to do meaningful things? And, how we would go about finding the source code or the Classes we need to do something cool in our application?

narrow down the search by typing:
site:microsoft.com

type the following:
site:microsoft.com write to a text file using c#
 */
