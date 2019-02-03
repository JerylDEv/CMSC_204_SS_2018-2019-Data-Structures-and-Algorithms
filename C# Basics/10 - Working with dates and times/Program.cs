using System;

namespace _10___Working_with_dates_and_times
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime myValue = DateTime.Now;
      Console.WriteLine($"Date and time now: {myValue.ToString()}");
      Console.WriteLine(myValue.ToShortDateString());
      Console.WriteLine(myValue.ToShortTimeString());
      Console.WriteLine(myValue.ToLongDateString());
      Console.WriteLine(myValue.ToLongTimeString());


      Console.ReadLine();
    }
  }
}

// paused at 4:00