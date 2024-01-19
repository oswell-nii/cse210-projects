using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter(fileName, false))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}, {entry._mood}");
            }
            Console.WriteLine("Entries Saved to File!");
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(", ");
            if (parts.Length >=3 )
            {
                string _date = parts[0].Trim();
                string _promptText = parts[1].Trim();
                string _entryText = parts[2].Trim();
                int _mood = int.Parse(parts[3].Trim());

                Entry entry = new Entry
            {
                _date = _date,
                _promptText = _promptText,
                _entryText = _entryText,
                _mood = _mood
            };
            _entries.Add(entry);
            }
            
            
        }
    }

}