using System;

public class Listing : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heros?"
    };

    public Listing()
        :base("Listing", "This activity will help you reflect on the good things in your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"---{prompts[rand.Next(prompts.Count)]}---");

        Console.WriteLine("\nYou may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        DisplayEndingMessage();
    }
}