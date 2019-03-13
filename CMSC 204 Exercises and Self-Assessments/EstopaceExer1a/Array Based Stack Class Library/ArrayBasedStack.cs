using System;

namespace Array_Based_Stack_Class_Library
{
  // This Class handles the logic of the application. Each method performs an operation. The View Model.cs handles the View or the Display of each Menu available in the Application.
  public class MyCustomStack
  {
    // I made this a static int to avoid the error in line 14 which says "A field initializer cannot reference the non-static field, method, or property 'CustomStack.maxStackCount' [Array Based Stack Class Library]". I also passed a value of 1000 so I could have a default number of item containers in the array. 
    static int maxStackCount = 1000;
    // The main idea here is to utilize a counter that is independent of the array's index. Using such counter makes it easier for me to track the order of the items.
    // I have initially set the value of the top of the stack to -1 so that the minimum index will be zero in the first execution of the Push method.
    int topOfTheStack = -1;
    // Initializing the array.
    string[] stackArray = new string[maxStackCount];

    // Call the Push method to add a data on top of the stack
    public void Push(string data)
    {
      if (topOfTheStack >= maxStackCount)
      {
        Console.WriteLine("The stack exceeded the maximum item count."); // in case of stack overflow.
      }
      else
      {
        stackArray[++topOfTheStack] = data;
        Console.WriteLine($"You have added {stackArray[topOfTheStack]}'s notebook.");
      }
    }

    // Call the PrintAll method to print all the items in the Stack
    public void PrintAll()
    {
      if (topOfTheStack == -1)
      {
        Console.WriteLine("The stack is empty."); // in case of Stack underflow
      }
      else
      {
        Console.WriteLine("Here are the remaining notebooks in the stack:");
        for (int index = topOfTheStack; index >= 0; index--)
        {
          Console.WriteLine($"{index + 1} = {stackArray[index]}");
        }
      }
    }

    // Call the Pop method to delete the current top item of the stack.
    public void Pop()
    {
      if (topOfTheStack == -1)
      {
        Console.WriteLine("The stack is empty."); // in case of Stack underflow
      }
      else
      {
        Console.WriteLine($"As such, {stackArray[topOfTheStack]}'s notebook has been removed from the stack.");
        topOfTheStack--;
      }
    }

    // Call the Peek method to print the current item on top of the stack.
    public void Peek()
    {
      if (topOfTheStack == -1)
      {
        Console.WriteLine("The stack is empty."); // in case of Stack underflow
      }
      else
      {
        Console.WriteLine($"{stackArray[topOfTheStack]}'s notebook is on top of the stack.");
      }
    }

    // Call the PeekAndPop method in order to peek on the notebook on top of the list and then pop it afterwards. I also called the PrintAll method so user will be aware of what is remaining in the stack.
    public void PeekAndPop()
    {
      if (topOfTheStack == -1)
      {
        Console.WriteLine("The stack is empty."); // in case of Stack underflow
      }
      else
      {
        Console.WriteLine($"{stackArray[topOfTheStack]}'s notebook is being checked.");
        Console.WriteLine(" ");
        this.Pop();
        Console.WriteLine(" ");
        if (topOfTheStack == -1)
        {
          Console.WriteLine("Congratulations! The stack is now empty.");
        }
        else
        {
          this.PrintAll();
        }
      }
    }

    // Call the ClearStack method to empty the stack.
    public void ClearStack()
    {
      if (topOfTheStack == -1)
      {
        Console.WriteLine("The stack is empty."); // in case of Stack underflow
      }
      else
      {
        this.PrintAll();
        topOfTheStack = -1;
        Console.WriteLine(" ");
        Console.WriteLine("All notebooks have been checked.");
        Console.WriteLine(" ");
        Console.WriteLine("Congratulations! The stack is now empty.");
      }
    }
  }
}
