using System;
// test
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
} 

//test again
//https://github.com/rcoleman31/cse210-projects/blob/main/csharp-prep/Prep1/Program.cs