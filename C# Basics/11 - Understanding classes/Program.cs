using System;

namespace _11___Understanding_classes
{
  class Program
  {
    static void Main(string[] args)
    {
      // Here's how we can create a New Instance of a Class
      // Step 1: Declare a new Car in Memory ( Car myCar )
      // Step 2: Instantiate/Create an Instance of Car Class and put it up in the Computer Memory ( = new Car() ) 
      Car myCar = new Car();

      // Setting the object properties
      myCar.Make = "Oldsmobile";
      myCar.Model = "Cutlas Supreme";
      myCar.Year = 1986;
      myCar.Color = "Silver";

      // Getting the object properties
      Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color}");

      // decimal marketValue = DetermineMarketValue(myCar);
      // Console.WriteLine($"{marketValue:C}");
      Console.WriteLine(myCar.DetermineMarketValue());

      Console.ReadLine();
    }
    // Uppercase C Car is used since we named our Class as such
    private static decimal DetermineMarketValue(Car car)
    {
      decimal carValue = 100.0M;
      return carValue;
    }
  }

  // I have defined a Car Class with 4 properties.
  // This Car Class allows us to define a Data Type that describes a car.
  // My aim here is to use this definition of what comprises a car in order to create additional instances of the Car Class that represent all of my Cars in my Car lot.
  // I'm creating a bucket in Computers Memory that's just the right size to hold information about any given car on my car lot.
  // Here, the Class is the Definition. But when we create a New Instance of this Class, then we are working with an Object.
  // The Class is the blueprint while the Object is something that is created as a result of having the blueprint or the pattern.
  // class Car is a new Data Type
  class Car
  {
    // 'prop' tab tab is the shortcut
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    // This a longer, more complete version of creating a property
    private int myVar;
    public int MyProperty
    {
      get { return myVar; }
      set { myVar = value; }
    }

    // Creating method in a class 
    public decimal DetermineMarketValue()
    {
      decimal carValue;
      if (Year > 1990)
      {
        carValue = 10000;
      }
      else
      {
        carValue = 2000;
      }
      return carValue;
    }

  }

}

// Pause at 4:20