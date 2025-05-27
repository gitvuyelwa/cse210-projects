using System;

public class Scripture
{
    private string _reference;
    private string _text;
    public List<Word> _words;
    public Scripture()
    {
        _reference = "John 3:16-17";
        _text = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        _words = new List<Word>();
        foreach (string word in _text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
   
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int count = 0;

        while (count < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference + "\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

       