using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "For God do loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "____";
        }
        else
        {
            return _text;
        }
    }
}