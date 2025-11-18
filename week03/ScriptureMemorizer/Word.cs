using System;


public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
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
    
    public void GetDisplayText()
    {
       if (_isHidden == true)
        {
            Console.Write("_");
        } else
        {
            Console.Write(_text);
        }
    }
}