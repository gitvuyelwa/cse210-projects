using System;

public class Entry
{

    public string _date { get; set; }
    public string _responseText { get; set; }
    public string _promptText { get; set; }

    public Entry(string prompt, string response)
    {
        _promptText = prompt;
        _responseText = response;
        _date = DateTime.Now.ToString("dd/MM/yyyy");
    }

    public string ToFileString()
    {
        return $"{_date} | {_promptText} | {_responseText}";
    }
    
        public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            var entry = new Entry(parts[1], parts[2]);
            entry._date = parts[0];
            return entry;
        }
        return null;
    }
}
    
