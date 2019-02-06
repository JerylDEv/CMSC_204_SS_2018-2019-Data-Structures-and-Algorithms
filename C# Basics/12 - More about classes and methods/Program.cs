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
