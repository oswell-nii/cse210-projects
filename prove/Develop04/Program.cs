using System;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;
        while (programRunning)
        {
            Console.WriteLine("Choose an activity");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Acctivity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu:");
            string userInput = Console.ReadLine();

            
            if (userInput == "1")
            {
                RunBreathingActivity();
            }
            else if (userInput == "2")
            {
                RunReflectingActivity();
            }
            else if (userInput == "3")
            {
                RunListingActivity();
            }
            else if (userInput == "4")
            {
                programRunning = false;
                Console.WriteLine("Program Ended");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
    }
        

    static void RunBreathingActivity()
    {
        Console.Clear();
        string activityName = "Breathing Activity";
        Console.Write($"Welcome to the {activityName}.\n");

        string activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind\nand focus on your breathing";
        Console.WriteLine($"{activityDescription}");

        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = int.Parse(Console.ReadLine());

        BreathingActivity breathingActivity = new BreathingActivity(activityName, activityDescription, userSeconds);
        breathingActivity.Run(userSeconds);

        Console.Clear();
    }

    static void RunReflectingActivity()
    {
        Console.Clear();
        string activityName = "Reflecting Activity";
        Console.Write($"Welcome to the {activityName}.\n");
        Console.WriteLine();

        string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        Console.WriteLine($"{activityDescription}");

        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        int userSeconds = int.Parse(Console.ReadLine());

        ReflectingActivity reflectingActivity = new ReflectingActivity(activityName, activityDescription, userSeconds);
        reflectingActivity.Run(userSeconds, activityName);

        Console.Clear();
    }

    static void RunListingActivity()
    {
        Console.Clear();
        string activityName = "Listing Activity";
        Console.Write($"Welcome to the {activityName}.\n");

        Console.WriteLine();


        string activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Console.WriteLine($"{activityDescription}");

        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like for your session");
        int userDuration = int.Parse(Console.ReadLine());

        int count = 0;
        ListingActivity listingActivity = new ListingActivity(activityName, activityDescription, userDuration, count);

        List<string> userResponse = listingActivity.GetListFromUser();
        listingActivity.Run(count, userDuration, activityName);

        Console.Clear();
    }
}       