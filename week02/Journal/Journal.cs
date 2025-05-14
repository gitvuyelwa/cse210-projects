using System;

class Journal
{
    public string _name;
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry  entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void LoadFromFile(string file)
    {
        foreach (Entry entry in _entries)
        {
            LoadFromFile(file);
        }
    }
    
    public void SaveToFile(string file)
    {
        foreach (Entry entry in _entries)
        {
            SaveToFile(file);
        }
    }
}