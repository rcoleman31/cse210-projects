using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input_number = -1;
        while (input_number != 0)
        {
            Console.Write("Enter number: ");

            string userResponse = Console.ReadLine();
            input_number = int.Parse(userResponse);
            
            if (input_number != 0)
            {
                numbers.Add(input_number);
            }
        }

        // Computing the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        // Computing the average
        float average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The average is: {average}");



        // Finding the max
        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");



        // Finding the smallest positive number
        int smallest_positive = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest_positive)
            {
                smallest_positive = number;
            }
        }       

        if (smallest_positive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallest_positive}");
        }
        else
        {
            Console.WriteLine("There were no positive numbers in the list.");
        }



        // Sorting and printing list
        numbers.Sort();

        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}