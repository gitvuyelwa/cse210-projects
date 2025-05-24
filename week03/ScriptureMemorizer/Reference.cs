using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;

    public Reference()
    {
        _book = "John";
        _chapter = 3;
        _verse = 16;
        _verseEnd = 17;
    }

    public string GetDisplayText()
    {
        if (_verseEnd == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
        }
    }
}