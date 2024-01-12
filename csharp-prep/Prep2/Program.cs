using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score: ");
        string userScore = Console.ReadLine();
        int score = int.Parse(userScore);

        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, try again next time");
        }
    }
}