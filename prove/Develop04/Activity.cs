public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name}, {_description}, {_duration}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"{_name} ended.");
    }
    public void ShowSpinner(int seconds)
    {
        DateTime spinnerEndTime = DateTime.Now.AddSeconds(seconds);
       
        while (DateTime.Now < spinnerEndTime)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }  
    }
    public void ShowCountDown(int seconds)
    {
        for (int countDown = seconds; countDown > 0; countDown--)
        {
            Console.Write(countDown);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}