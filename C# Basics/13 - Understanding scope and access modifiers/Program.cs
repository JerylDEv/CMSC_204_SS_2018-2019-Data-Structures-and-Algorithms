using System;

namespace _13___Understanding_scope_and_access_modifiers
{
  class Program
  {
    /* 
    A private field is sort of a property except that it is private an nature but it is available to all of the members of the class.
    */
    private static string k = "";
    static void Main(string[] args)
    {
      string j = "";
      for (int i = 0; i < 10; i++)
      {
        j = i.ToString();
        k = i.ToString();

        if (i == 9)
        {
          string l = i.ToString();
        }
        // Console.WriteLine(l); // The name 'l' does not exist in the current context [13 - Understanding scope and access modifiers]

        Console.WriteLine(i);
      }
      // Console.WriteLine(i); i does not exist in the current context.
      /*
      Since we defined outside the scode of the For statement, we can access it inside the For statement and outside it.
       */
      Console.WriteLine($"Outside of the for: {j}"); // 9 
      Console.WriteLine($"Outside of the for: {k}"); // 9

      /*
        k was defined at Class level. It is sibling to Main and HelperMethod therefore it is accessible to each of these codeblocks including their inner code blocks.
       */
      HelperMethod(); // 9

      /*
      If we are going to work with Car Class inside of the Main Class, notice that we can only work with the Car Class > DoSomething() Method.
      We can't see the other methods inside of the Car Class since they are marked as Private.
      It's like all we need to know is that we can work with Car Class through its DoSomething() Method.
      All the implementation details of the DoSomething method will be hidden from us but it will work as expected.
       */
      Car myCar = new Car();
      myCar.DoSomething();

      Console.ReadLine();
    }

    static void HelperMethod()
    {
      Console.WriteLine($"Value of k from HelperMethod: {k}");
    }
  }

  class Car
  {
    public void DoSomething()
    {
      Console.WriteLine(helperMethod());
    }

    private string helperMethod()
    {
      return "Hello World!";
    }
  }
}

/*
Variables Scopes

Whenever we declare a variable inside a block of code, that variable is only alive for the life of that code block and any of its interior code blocks.
This means that wehen the code block is finished executing, the variable that was defined inside of that code block is no longer accessible and its values are disposed of by the .NET Framework runtime.
 */

/*
Accessibility Modifiers (public vs private keyword)

public and private keyword are both accessibility modifiers. They are used to implement a topic in Object Oriented Programming called Encapsulation.
In a nutshell, we could think of Classes as Black Boxes where all of it's inner parts are self-contained (Old TV sets where we switch the knob to change the channel).
All the important behind the scenes functionalities should be encapsulated behind interfaces like public methods and public properties.
Now Classes might in fact have private fields or private methods that are used behind the scenes to add some functionality to those Public methods that are exposed to anybody who needs to work on that Class through that Public method. But the consumer (like Main Class) of that Class shouldn't know anything about the inner workings of that Class in order to work or operate with the Class. All they need to know iswhat is publicly exposed through the public properties and public methods.

Private means that a Method can be called by any other method inside of the same Class.

A Public Method is what's actually gonna be then called by some other code outside of the Class.
A Private Method are only gonna be called by members inside of the class.
 */

/*
Tip: We should strive to expose Public Methods and give a simple, straight forward, obvious way to call Public Methods from our Class but keep all the other Helper Methods and all the other internals privately tucked away and not available to prying eyes by setting them as Private.
 */

/*
Other types of accessibility modifiers
 - protected
 - internal
These are primarily used when we are working for a rich inheritance classes or when we are working for a very large library that's compiled into separate assemblies.
 */

// Completed at 5:22:38