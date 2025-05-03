using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        string again = "yes";
        Random rnd = new Random();
        while (again == "yes"|| again == "Yes")
        {
            int guess = 0;
            int magic = rnd.Next(1,11);
            while (guess != magic)
            {
                Console.WriteLine("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
            }
            Console.WriteLine($"You win! You guessed: {magic}");
        }
    }
}