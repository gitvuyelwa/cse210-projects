using System;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayEntry()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine("Journal saved.");
    }
    public void LoadFromFile(string filename)
    {
        foreach (Entry entry in _entries)
        {
            LoadFromFile(filename);
        }
    }

}
    