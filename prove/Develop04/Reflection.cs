using System;

public class Reflection : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up to someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truely selfless.",
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you apply this in the future?",
    };

    public Reflection()
        : base("Reflection", "")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"---{prompts[rand.Next(prompts.Count)]}---");
        Console.WriteLine("\nWhen you have something in mind press enter.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on the folloiwng questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

}