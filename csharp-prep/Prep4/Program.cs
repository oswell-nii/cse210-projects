using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        List<int> numbers = new List<int>();
        int totalItems = 0;

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
                totalItems += number;
            }
        } while (number != 0);


        Console.WriteLine($"The sum is: {totalItems}");

        double average = numbers.Count > 0 ? numbers.Average() : 0.0;
        Console.WriteLine($"The average is: {average}");

        int maxValue = numbers.Count > 0 ? numbers.Max() : 0;
        Console.Write($"The largest number is: {maxValue}");
    }
}