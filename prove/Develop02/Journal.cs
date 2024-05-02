using System.IO.Enumeration;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine(newEntry._promptText);
        Console.Write("> ");
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadJournal(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        _entries.Clear();
        
        foreach (string line in lines)
        {   
            Entry entry = new Entry();
            string[] parts = line.Split("­");
            entry._date = parts[1];
            entry._promptText = parts[3];
            entry._entryText = parts[5];
            _entries.Add(entry);
        }

    }
    public void SaveEntry(string file)
    {
        using (StreamWriter saveFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                saveFile.WriteLine($"Date: ­{entry._date}­ - Prompt: ­{entry._promptText}­ - Entry: ­{entry._entryText}­");
            }
        }
    }
}