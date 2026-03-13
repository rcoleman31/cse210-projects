// EXCEEDING REQUIREMENTS
// I added a leveling system to make the progream more like a game. The user gains a new level every 1000 points, giving additional motivation to complete goals.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest");
            manager.DisplayScore();
            manager.DisplayLevel();

            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1. Create Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    manager.AddGoal(new Simple(name, desc, points));
                }

                else if  (type == "2")
                {
                    manager.AddGoal(new Eternal(name, desc, points));
                }

                else if (type == "3")
                {
                    Console.Write("Target Count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(new Checklist(name, desc, points, target, bonus));
                }
            }

            else if (choice == "2")
            {
                manager.ListGoals();
            }

            else if (choice == "3")
            {
                manager.ListGoals();

                Console.Write("Which goal did you complete? ");
                int num = int.Parse(Console.ReadLine()) - 1;

                manager.RecordGoals(num);
            }

            else if (choice == "4")
            {
                running= false;
            }
        }
    }
}