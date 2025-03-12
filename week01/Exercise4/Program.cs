using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int input;

        // Step 1: Collect numbers from the user
        do
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out input) && input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        // Step 2: Compute the sum of the numbers
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Step 3: Compute the average of the numbers
        if (numbers.Count > 0)
        {
            double average = numbers.Average();
            Console.WriteLine($"The average is: {average}");
        }
        else
        {
            Console.WriteLine("The average is: 0");
        }

        // Step 4: Find the maximum number
        if (numbers.Count > 0)
        {
            int max = numbers.Max();
            Console.WriteLine($"The largest number is: {max}");
        }

        // Stretch 1: Find the smallest positive number
        int? smallestPositive = numbers.Where(n => n > 0).OrderBy(n => n).FirstOrDefault();
        if (smallestPositive.HasValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        // Stretch 2: Sort the list and display it
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}