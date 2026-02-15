using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _random = new Random();
        _words = new List<Word>();

        string [] splitWords = text.Split(' ');

        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int randomIndex = _random.Next(_words.Count);

            if (!_words[randomIndex].Hidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }

            if (AllWordsHidden())
            {
                break;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Hidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n\n";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }
}