using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        Console.WriteLine($"The magic number is {randomNumber}");
        
        int guessedNumber;

        do
        {
            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guessedNumber != randomNumber);
    }      
}
