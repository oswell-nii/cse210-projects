public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
    };

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run(int userSeconds, string activityName)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} --- ");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        string pressEnter = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(pressEnter))
        {   
            Console.WriteLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in ");

            ShowCountDown(6);
        }

        Console.Clear();

        foreach (var question in _questions)
        {
            Console.Write($"> {question} ");
            ShowSpinner(5);
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {userSeconds} seconds of the {activityName}.");
        ShowSpinner(5);
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_prompts.Count)];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"{_prompts}");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($"{_questions}");
    }

}