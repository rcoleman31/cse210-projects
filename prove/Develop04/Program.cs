using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing activity = new Breathing();
                activity.Run();
            }
            else if (choice == "2")
            {
                Reflection activity = new Reflection();
                activity.Run();
            }
            else if (choice == "3")
            {
                Listing activity = new Listing();
                activity.Run();
            }
        }
    }
}