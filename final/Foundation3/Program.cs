using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address addr2 = new Address("456 Center St", "Idaho Falls", "ID", "USA");
        Address addr3 = new Address("789 Park Ave", "Boise", "ID", "USA");

        Lecture lecture = new Lecture(
            "Math Lecture",
            "learning about Calculus",
            "March 30",
            "10:00 AM",
            addr1,
            "Dr. Smith",
            100
        );

        Reception reception = new Reception(
            "Wedding Reception",
            "Celebrate together",
            "April 5",
            "6:00 PM",
            addr2,
            "rsvp@email.com"
        );

        Outdoor outdoor = new Outdoor(
            "Community Picnic",
            "Food and games",
            "May 10",
            "12:00 PM",
            addr3,
            "Sunny"
        );

        Event[] events = { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(e.GetStandardDetails());

            Console.WriteLine("\n----- Full Details -----");
            Console.WriteLine(e.GetFullDetails());

            Console.WriteLine("\n----- Short Description -----");
            Console.WriteLine(e.GetShortDescription());

            Console.WriteLine("\n----------------------------------\n");
        }
    }
}

