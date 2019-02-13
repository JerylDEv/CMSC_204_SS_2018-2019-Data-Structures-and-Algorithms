using System;
using System.Collections;
using System.Collections.Generic;

namespace _16___Working_with_collections
{
  class Program
  {
    static void Main(string[] args)
    {
      Car car1 = new Car();
      car1.Make = "Toyota";
      car1.Model = "Supra";
      car1.VIN = "A1";

      Car car2 = new Car();
      car2.Make = "Ford";
      car2.Model = "Expedition";
      car2.VIN = "A2";

      Book book1 = new Book();
      book1.Author = "John Grisham";
      book1.Title = "Rogue Lawyer";
      book1.ISBN = "0-100-00000000-0";

      Book book2 = new Book();
      book1.Author = "John Grisham";
      book1.Title = "The Broker";
      book1.ISBN = "0-200-00000000-0";

      /*
      ArrayLists are dynamically sized, support cool features like sorting, and remove items.
      The problem with this old style colelctions is that there is no way to limit the type of data that would be stored inside the Array. This is not strongly type in so much that you can put anything in the collection.
      */
      ArrayList myArrayList = new ArrayList();
      myArrayList.Add(car1);
      myArrayList.Add(car2);
      myArrayList.Add(book1);
      myArrayList.Remove(book1);

      foreach (Car car in myArrayList)
      {
        /* 
        The error below will be encountered if book1 is not removed from myArrayList.

        Unhandled Exception: System.InvalidCastException: Unable to cast object of type 'Book' to type 'Car'. at _16___Working_with_collections.Program.Main(String[] args) in C:\Users\accessadmin\Documents\2 - UPOU\CMSC 204\C# Basics\16 - Working with collections\Program.cs:line 32
         */
        Console.WriteLine(car.Make);
      }

      /*
      Newer Style Collections
      1. Generic Lists - needs to specify the Data Type
      2. Dictionary - is composed of a Key (should be a unique identifier) and a Value (the Data Type or Class)
      */
      // List<T or Data Type or Class>
      List<Car> myCarList = new List<Car>();
      myCarList.Add(car1);
      myCarList.Add(car2);
      /* 
      myCarList.Add(book1);

      Argument 1: cannot convert from '_16___Working_with_collections.Program.Book' to '_16___Working_with_collections.Program.Car' [16 - Working with collections]
      */

      foreach (Car car in myCarList)
      {
        Console.WriteLine(car.Model);
      }

      // Dictionary<TKey, TValue>
      Dictionary<string, Car> myCarDictionary = new Dictionary<string, Car>();
      myCarDictionary.Add(car1.VIN, car1);
      myCarDictionary.Add(car2.VIN, car2);

      Console.WriteLine($"Here's the Model of my {car2.Make}, {myCarDictionary["A2"].Model}");

      // Array Declaration and Initialization
      // string[] names = {"Jeryl", "Ara", "Athena", "Mavis"};

      // Object Initializer
      Car car3 = new Car() { Make = "BMW", Model = "750li", VIN = "A3" };
      Car car4 = new Car() { Make = "Bugatti", Model = "Chiron", VIN = "A4" };

      // Collection Initializer
      List<Car> myList = new List<Car>()
      {
        new Car { Make="Chevrolet", Model="D-Max", VIN="A5"},
        new Car { Make="Toyota", Model="Avanza", VIN="A6"}
      };

      Console.ReadLine();
    }

    class Car
    {
      public string Make { get; set; }
      public string Model { get; set; }
      public string VIN { get; set; }
    }

    class Book
    {
      public string Title { get; set; }
      public string Author { get; set; }
      public string ISBN { get; set; }
    }
  }
}
/*
Collections
1. Lists - 
2. Dictionaries - 

Collections are essentially Generic but it requires that we make it Specific by giving it the Data Type that should be allowed inside of that Collection.

LINQ - Language Integrated Query
*/

// Completed at 1:52
