using System;

namespace _10___Working_with_dates_and_times
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime myValue = DateTime.Now;
      Console.WriteLine($"Date and time now: {myValue.ToString()}");
      Console.WriteLine($"Short date string: {myValue.ToShortDateString()}");
      Console.WriteLine($"Short time string: {myValue.ToShortTimeString()}");
      Console.WriteLine($"Long date string: {myValue.ToLongDateString()}");
      Console.WriteLine($"Long time string: {myValue.ToLongTimeString()}");

      Console.WriteLine($"Long date string + 3 days: {myValue.AddDays(3).ToLongDateString()}");

      Console.WriteLine($"Long time string + 3 hours: {myValue.AddHours(3).ToLongTimeString()}");

      Console.WriteLine($"Long time string - 3 hours: {myValue.AddHours(-3).ToLongTimeString()}");

      Console.WriteLine($"Current Month: {myValue.Month}");

      DateTime myBirthday = new DateTime(1990, 1, 1);
      Console.WriteLine(myBirthday.ToShortDateString());

      DateTime myBirthdayVer2 = DateTime.Parse("10/01/1990");
      TimeSpan myAge = DateTime.Now.Subtract(myBirthdayVer2);
      Console.WriteLine($"I'm alive for {myAge.TotalDays} days.");


      Console.ReadLine();
    }
  }
}

// completed at 4:07