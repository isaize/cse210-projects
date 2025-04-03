using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Display the scripture with hidden words
    public void Display()
    {
        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _words)
        {
            Console.Write(word.IsHidden ? new string('_', word.Text.Length) + " " : word.Text + " ");
        }
        Console.WriteLine();
    }

    // Hide a random word
    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);  //i learn this code on you tube on C# learning for beginners
        _words[index].Hide();
    }

    // Check if all words are hidden
    public bool AllWordsHidden() //i learn this code on you tube on C# learning for beginners
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}