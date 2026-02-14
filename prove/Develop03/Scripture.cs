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
        
    }
}