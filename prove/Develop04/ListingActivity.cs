public class ListingActivity : Activity
{
    public int _count;
    List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
    }
    public void Run(int durationInSeconds, int userDuration, string activityName)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} --- ");
        Console.Write("You may begin in: ");

        ShowCountDown(5);
        
        int remainingSeconds = durationInSeconds;
        DateTime endTime = DateTime.Now.AddSeconds(userDuration);
        Console.WriteLine();
        do
        {
            Console.Write($"> ");
            string userResponse = Console.ReadLine();
            _count++;
            remainingSeconds = (int)Math.Max(0, (endTime - DateTime.Now).TotalSeconds);
        } while (DateTime.Now < endTime);

        Console.WriteLine($"You made {_count} entries.");
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {userDuration} seconds of the {activityName}.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userResponse = new List<string>();

        return userResponse;
    }
    
}