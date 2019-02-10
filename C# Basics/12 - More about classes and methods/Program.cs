using System;

namespace _12___More_about_classes_and_methods
{
  class Program
  {

    static void Main(string[] args)
    {
      /*
        We will still be using the Method Invocation Operator () even if we erase the Car Class Constructors are not defined, because a Default Constructor is automatically created whenever we compile our Classes. It will be a Constructor without any input parameters and will have no body. (i.e. public Car() { // Empty })
       */
      Car myCar = new Car();
      myCar.Make = "Old mobile";
      myCar.Model = "Toyota Supra";
      myCar.Year = 1994;
      myCar.Color = "Red";

      // Even though we set the properties of myCar, since we copy the reference (myCar) to the Car Object and the Computer's Memory in to a new Variable called myOtherCar, we could still get to the values that are in the memory because they are pointing to the same Object
      Car myOtherCar;
      myOtherCar = myCar;

      Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model} {myOtherCar.Year} {myOtherCar.Color}");

      myOtherCar.Model = "Toyota Fortuner";
      Console.WriteLine($"{myCar.Model}");
      Console.WriteLine($"{myOtherCar.Model}");

      // As references go out of scope (in other words, whenever the current thread of execution leaves the current code block that we're currently in, or those object references are set to null intentionally by the Software Developer), then the number of references (or "handles") to the Object then go to zero. And so, here again, when the .NET Framework runtime looks to the memory and finds those objects that have a reference count of zero, it will remove those Objects from the computer's memory.

      /* 
      The 2 Scenarios in which the connections to the Object get removed:
      
      1. When References go out of scope - whenever we create a new variable called myCar it will continue to be in scope as long as we are inside of the Main Method. When we exit of the Main Method, the variable go out of scope and we cannot access it any longer.
      
      2. If we as Software Developers actively take a role in removing the "Handles" from the buckets in Computer's Memory - We can do this by setting the Objects equal to "Null" (which means indeterminate).
      
      myOtherCar = null;

      Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model} {myOtherCar.Year} {myOtherCar.Color}");

      Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object.
      // at _12___More_about_classes_and_methods.Program.Main(String[] args) in C: \Users\accessadmin\Documents\2 - UPOU\CMSC 204\C# Basics\12 - More about classes and methods\Program.cs:line 32 Segmentation fault

      Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model} {myOtherCar.Year} {myOtherCar.Color}");
      */

      myOtherCar = null;

      /*
        Whenever we set the reference to Null or whenever our references get out of scope, we will be removing all the reference to our Objects. But the .NET Framework runtime itself figures out when will it be ready and willing to remove those objects from Memory completely.

        In most cases, this is not a problem.
        Occassionally, we may encounter situation where this is a problem. The remedy for this is called "Deterministic Finalization".
       */

      Car myThirdCar = new Car();
      Console.WriteLine(myThirdCar.Make);

      Car myFourthCar = new Car("Ford", "Mustang", 2017, "Blue");
      Console.WriteLine($"{myFourthCar.Make} {myFourthCar.Model} {myFourthCar.Year} {myFourthCar.Color}");

      Car.MyMethod();

      Console.ReadLine();
    }
  }

  class Car
  {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }


    /*
    Constructors

    A Constructor is a method that allows us Software Developers to execute code at the moment that a new instance of the Object is created.

    Car myCar = new Car();

    Notice that whenever we use the "new" keyword and we give it the name of the Class that we want to create a new instance of, we are also calling it using the method invocation operator.

    We are actually calling a Method, whenever we create a new instance of a Class. And that Method is referred to as a Constructor. It allows us the Software Developer, the option to write some code at that very moment whenever a new instance of a Class is created.

    Typically, Constructors are used in order to put that new Object in to a "Valid State". Meaning that we can use it to initialize the values of the properties of that given Object, and so its immediately usable.

    Let's say we want to create a Constructor that will allow us to set a Property of the Car at the point whenever we create a Car Class. That Property is available immediately in the very next line of code, whenever we begin to work with it.
    */

    /*
      By default, whenever we create a new Car Class, we are goind to set one of its Properties, the Make property to "Nissan".

      The "this" keyword is optional. It refers to "this instance of this Object". This is used to clarify where this variable or name (i.e. Make) is coming from.
     */
    public Car()
    {
      /*
      We could load values in to the various Properties of our Class from a configuration file, a database, etc. in order to get that object in to a "Valid State" so that's immediately usable at the point of instantiation.
      */
      this.Make = "Nissan";
    }

    /*
    Overloaded Constructor

    We will often see this whenever we work with Objects in  the .NET Framework Class Library. Just like when we create an overloaded Method in our Classes by changing the Method's Signature (meaning, the number and the Data Type of the Input Parameters for the Method), we can do the same thing with the Constructor
    */

    public Car(string make, string model, int year, string color)
    {
      Make = make;
      Model = model;
      Year = year;
      Color = color;
    }

    /*
    Static Keyword

    Adding Static Keyword means that we do not have to create an Instance of the Class in order to utilize its Methods and Properties. (i.e. Console.WriteLine(""))
    */
    public static void MyMethod()
    {
      Console.WriteLine("Called the static MyMethod");
      /*
      Working with Classes with Static Members vs Instance Members:
        - Instance Members are a series of Properties that describe, or Methods (i.e. Constructors) that operate on a single instance of a given entity like Car.
        - Static Members are Utilities (they don't operate on any single instance), they can be used anytime because they do not depend on a state of a given instance of a Class or even the Application itself. They can be used any time because they are not tied to a specific Car, they are true of all Cars and can be used at any time.

      Console.WriteLine(Make);

      Results to:
      An object reference is required for the non-static field, method, or property 'Car.Make'[12 - More about classes and methods]
      string Car.Make
      
      Note: Why would we need to create a static member of a Class? We could learn from "Design Patterns", "Coding Heuristics"

       - For Static Members, we cannot reference any instance members (Instance Members, Instance Properties, Instance Methods). These instance members require an instance of a class to operate.
       */
    }
  }
}

// Pause at 4:31 

/*
  The computer's memory has addresses and are typically represented in hexadecimal values

  The .NET framework's first job is to find an empty available address that has no data stored, and is large enough to store our instance of a Class.

  The .NET Framework will then create the object instance and it will copy any of its values that are currently stored in that object instance, up in to that memory address.

  Then it takes note of the address of the computer memory where it put the instance of that object. 

  And then it serves the address of the object back to us.

  And we store that address in the instance name of our Class (i.e. myCar)

  The Variable myCar is holding on to an address in the computer's memory where we could access the object once again.

  Now, whenever we need to access the new instance of a Car Class, we merely can use it's reference name (i.e. myCar)

  To summarize, myCar is holding an address, it's a reference to an instance of a Car Class in the computer's memory. Whenever we need to work with this instance of a Car Class we could use the myCar identifier and the .NET Framework runtime takes care of everything for us.

  The .NET Framework runtime will be constantly monitoring the memory that it manages. It is looking for objects that no longer had any 'handles' associated with them. Once we let go of the handle, the reference count will go to zero.
  
  At that point, the .NET Framework runtime will remove it and throw it in the garbage (Concept of Garbage Collection in C#).

  The process of monitoring memory for objects which do not have any references to them is called Garbage Collection.
*/



