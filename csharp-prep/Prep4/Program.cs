using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int enter = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (enter != 0)
        {
            Console.WriteLine("Enter number: ");
            string input = Console.ReadLine();
            enter = int.Parse(input);
            if (enter != 0)
            {
                numbers.Add(enter);
            }
        }
        int sum = 0;
        int large = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > large)
            {
                large = number;
            }
        }
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"Sum: {sum} \nAverage: {average}\nLargest number: {large}");
        

    }
}