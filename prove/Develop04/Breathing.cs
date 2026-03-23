using System;

public class Breathing : Activity
{
    public Breathing()
        : base("Breathing", "This activity will help you relx by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(4);

            Console.Write("\nBreathe out...");
            ShowCountdown(4);
        }

        DisplayEndingMessage();
    }
}