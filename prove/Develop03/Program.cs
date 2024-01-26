using System;

class Program
{
    static void Main(string[] args)
    {
        var singleVerseReference = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
        var verseRangeReference = new Scripture(new Reference("Proverbs", 3, 5, 6),"Trust in the LORD with all your heart and lean not on your own understanding; In all your ways acknowledge him, and he will make your paths straight.");
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to our Scripture Memorizer Program!\n");
            Console.WriteLine(verseRangeReference.GetDisplayText());

            if (verseRangeReference.HasVisibleWords())
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to quit the program");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                {
                    break;
                }  
                
                verseRangeReference.HideRandomWords(1);

            } 
            else 
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to quit the program");
                string userInput = Console.ReadLine();
                break;
                
            }

        }    
    }
}