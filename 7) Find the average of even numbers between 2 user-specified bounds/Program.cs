using System;

class Program
{
  static void Main()
  {
    int lowerBound, upperBound;
    decimal averageValue = 0;
    bool exit = false;

    do
    {
      // Prompt the user for the lower and upper bounds
      Console.Write("Enter the lower bound: ");
      lowerBound = int.Parse(Console.ReadLine());

      Console.Write("Enter the upper bound: ");
      upperBound = int.Parse(Console.ReadLine());

      try
      {
        // Calculate the sum of the even numbers between the bounds
        averageValue = CalculateAverageOfEvenNumbers(lowerBound, upperBound);

        // Display the result to the user
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        exit = true; // Set exit flag to exit the loop
      }
      catch (ArgumentOutOfRangeException ex)
      {
        HandleInvalidInput(ex);
      }
    } while (!exit); 
  }

  static decimal CalculateAverageOfEvenNumbers(int lowerBound, int upperBound)
  {
    // Check if the lower bound is greater than or equal to the upper bound
    if (lowerBound >= upperBound)
    {
      throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
    }

    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
      if (i % 2 == 0)
      {
        sum += i;
        count++;
      }
    }

    average = (decimal)sum / count;

    return average;
  }

  static void HandleInvalidInput(ArgumentOutOfRangeException ex)
  {
    Console.WriteLine("An error has occurred.");
    Console.WriteLine(ex.Message);
    Console.WriteLine($"The upper bound must be greater than {lowerBound}");
    Console.Write("Enter a new upper bound (or enter 'Exit' to quit): ");
    string userResponse = Console.ReadLine();

    if (userResponse.Equals("Exit", StringComparison.OrdinalIgnoreCase))
    {
      exit = true; // User chose to exit the loop
    }
    else
    {
      // Attempt to parse the user input as the new upper bound
      if (int.TryParse(userResponse, out int newUpperBound))
      {
        upperBound = newUpperBound; 
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter a valid integer."); /
      }
    }
  }
}
