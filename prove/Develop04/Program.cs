using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool Repeat = true;
        while (Repeat)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listening Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            int descision = int.Parse(choice);
            switch (descision)
            {
                case 1:
                    {
                        Breathing myBreathing = new Breathing();
                        myBreathing.BreathingActivity();
                        break;
                    }
                case 2:
                    {
                        Reflecting myReflecting = new Reflecting();
                        myReflecting.ReflectingActivity();
                        break;
                    }
                case 3:
                    {
                        Listing myListing = new Listing();
                        myListing.ListingActivity();
                        break;
                    }
                case 4:
                    {
                        Repeat = false;
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Please type in a number 1-4.");
                        Thread.Sleep(3000);
                        break;
                    }
            }
        } 
        Console.Clear();
        Console.WriteLine("\nGoodbye!\n");
            
    }
}