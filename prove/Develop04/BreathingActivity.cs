public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }
    public void Run(int userSeconds)
    {

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        int totalBreathingCycle = userSeconds / 5;

        for (int cycle = 0; cycle < totalBreathingCycle; cycle++)
        {
            int breatheInCount = 3 + cycle;
            int breatheOutCount = 4 + cycle;

            Console.Write("\nBreathe in...");
            for (int count = breatheInCount; count > 0; count--)
            {
                Console.Write($"{count}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Write("\nNow breathe out...");
            for (int count = breatheOutCount; count > 0; count--)
            {
                Console.Write($"{count}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
  
        }    
        
        Console.WriteLine();    
        Console.WriteLine("Well Done!!");
        Console.WriteLine();

        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {userSeconds} seconds of the Breathing Activity.");
        ShowSpinner(5);
    }


}