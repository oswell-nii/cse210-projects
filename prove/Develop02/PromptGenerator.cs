using System;

public class PromptGenerator
{    
    public List<string> _prompts = new List<string>();
    Random Random = new Random();

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}
