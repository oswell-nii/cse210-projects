using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts.Add("What was the best part of your day? ");
        promptGenerator._prompts.Add("Who was the most interesting person you met today? ");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today? ");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today? ");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be? ");
        promptGenerator._prompts.Add("Did I forget to pray today? ");
        promptGenerator._prompts.Add("Who did I help today? ");

        Console.Write("Welcome to the Journal Program!");

        do 
        {
            bool displayChoices = true;
            while (displayChoices)
            {
                Console.Write("\nPlease select one of the following choices:\n");
                journal.DisplayAll();
                Console.Write("\nWhat would you like to do? ");
            
            
                string choices = Console.ReadLine();

                if (choices == "1")
                {
                    string randomPrompt = promptGenerator.GetRandomPrompt();

                    DateTime currentDate = DateTime.Now;
                    Entry entry = new Entry();
                    entry._date = currentDate.ToShortDateString();
                    entry._promptText = randomPrompt;
                    journal.AddEntry(entry);

                    Console.WriteLine($"{randomPrompt}");
                    
                    Console.Write("> ");
                    string entryText = Console.ReadLine();
                    entry._entryText = entryText;


                    //Exceeding program requirements. Added mood to rate user's mood at the time of journal entry
                    Console.WriteLine("What is your mood today? (1-10) ");
                    Console.Write("> ");
                    string moodInput = Console.ReadLine();

                    if (int.TryParse(moodInput, out int mood) && mood <= 1 && mood <= 10)
                    {
                        entry._mood = mood;
                    }
                    else
                    {
                        Console.WriteLine("Invalid mood input. Mood set to 0.");
                        entry._mood = 0;
                    }

                    displayChoices = false;
                }

                else if (choices == "2")
                {
                    journal.DisplayAllEntries();
                    displayChoices = false;
                }
                else if (choices == "3")
                {
                    Console.Write("Enter a filename to load entries: ");
                    string fileName = Console.ReadLine();

                    journal.LoadFromFile(fileName);
                    displayChoices = false;
                }
                else if (choices == "4")
                {
                    Console.Write("What is the filename? (in txt) ");
                    string fileName = Console.ReadLine();

                    journal.SaveToFile(fileName);
                    displayChoices = false;
                }
                else if (choices == "5")
                {
                    Console.WriteLine("Program exited!");
                    return;
                }
            }
        } while (true);
    }
}