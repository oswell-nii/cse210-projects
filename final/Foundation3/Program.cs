using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an address
        Address address1 = new Address("123 Main St", "Anytown", "State", "12345");

        // Create events of each type
        Lecture lectureEvent = new Lecture("Lecture Title", "Lecture Description", DateTime.Now, TimeSpan.FromHours(2), address1, "John Doe", 50);
        Reception receptionEvent = new Reception("Reception Title", "Reception Description", DateTime.Now.AddDays(7), TimeSpan.FromHours(3), address1, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Outdoor Gathering Title", "Outdoor Gathering Description", DateTime.Now.AddDays(14), TimeSpan.FromHours(4), address1, "Sunny");

        // Generate and output marketing messages
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\nReception Event:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    
    }
}