using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private PromptGenerator generator = new PromptGenerator();

    public void WriteEntry()
    {
        string randomPrompt = generator.GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        string response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Entry newEntry = new Entry();
        newEntry._date = dateText;
        newEntry._promptText = randomPrompt;
        newEntry._response = response;

        _entries.Add(newEntry);
        Console.WriteLine("Entry Saved");
    }

    public void DisplayAll()
    {
        foreach (Entry i in _entries)
        {
            i.Display();
        }
    }
    
    public void LoadFromFile()
    {
        string filename = "Entries.csv";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            Console.WriteLine($"Date: {parts[0]}");
            Console.WriteLine($"Prompt: {parts[1]}");
            Console.WriteLine($"Response: {parts[2]}");
        }
    }
    public void SaveToFile()
    {
        string filename = "Entries.csv";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry i in _entries)
            {
                outputFile.WriteLine($"{i._date}|{i._promptText}|{i._response}");
            }
        }
    }
}

