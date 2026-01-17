using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string user_name = PromptUserName();
        int user_number = PromptUserNumber();

        int squared_number = SquareNumber(user_number);

        int birth_year;
        PromptUserBirthYear(out birth_year);

        DisplayResult(user_name, squared_number, birth_year);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void PromptUserBirthYear(out int birth_year)
    {
        Console.Write($"Please enter the year you were born: ");
        birth_year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birth_year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {2026 - birth_year} years old this year.");
    }
}