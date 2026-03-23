using System;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up to someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truely selfless.",
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before",
        "How did you get started",
        "How did you feel when it was complete?",
        "What made this time idfferent than other times when oyu were not as successful?",
        "What is your favorite thing about this expereince?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    private List<string> _unusedPrompts;

    private List<string> _unusedQuestions;

    private string GetNextPrompt()
    {
        if(_unusedPrompts.Count == 0)
        {
            _unusedPrompts = ShuffleList(_prompts);
        }

        string next = _unusedPrompts[0];
        _unusedPrompts.RemoveAt(0);
        return next;
    }

    private string GetNextQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = ShuffleList(_questions);
        }

        string next = _unusedQuestions[0];
        _unusedQuestions.RemoveAt(0);
        return next;
    }

    public Reflection()
        : base("Reflection", "This activity will help you reflect on times inn your life when you have shown strength and resilience. " + "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        _unusedPrompts = ShuffleList(_unusedPrompts);
        _unusedQuestions = ShuffleList(_questions);

        Random rand = new Random();

        Console.WriteLine("\nConsider the following prompt:");

        string prompt = GetNextPrompt();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("\nWhen you have something in mind press enter.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on the folloiwng questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetNextQuestion();
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

}