using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "What is one thing you learned today?",
        "What is something you are grateful for today?",
        "If you could do one thing differently today, what would it be?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}