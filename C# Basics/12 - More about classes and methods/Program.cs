using System;

namespace _12___More_about_classes_and_methods
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myCar = new Car();
      Console.ReadLine();
    }
  }

  class Car
  {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
  }
}

// Pause at 4:31 

// The computer's memory has addresses and are typically represented in hexadecimal values
// The .NET framework's first job is to find an empty available address that has no data stored, and is large enough to store our instance of a Class.
// The .NET Framework will then create the object instance and it will copy any of its values that are currently stored in that object instance, up in to that memory address.
// Then it takes note of the address of the computer memory where it put the instance of that object. 
// And then it serves the address of the object back to us.
// And we store that address in the instance name of our Class (i.e. myCar)
// The Variable myCar is holding on to an address in the computer's memory where we could access the object once again.
// Now, whenever we need to access the new instance of a Car Class, we merely can use it's reference name (i.e. myCar)
// To summarize, myCar is holding an address, it's a reference to an instance of a Car Class in the computer's memory. Whenever we need to work with this instance of a Car Class we could use the myCar identifier and the .NET Framework runtime takes care of everything for us.
