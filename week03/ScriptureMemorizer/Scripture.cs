using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word word1 = new Word(word);
            _words.Add(word1);

        }
    }

    public void HideRandomWords(int numberToHide = 1)
    {
        Random random = new Random();
        int noOfWordsHiddenSoFar = 0;

        while (noOfWordsHiddenSoFar < numberToHide)
        {
            int index = random.Next(_words.Count);

            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                noOfWordsHiddenSoFar += 1;
            } 
        }   
    }

    public void GetDisplayText()
    {
       
        foreach (Word word in _words)
        {
            word.GetDisplayText();
            Console.Write(" "); 
        }

        Console.WriteLine(); 
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
    

}