using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

class Program
{
    static int _breathing = 0;
    static int _reflect = 0;
    static int _listing = 0;
    static void ActivityCounter(int numbs)
    {
        switch (numbs)
        {
            case 1:
                {
                    _breathing += 1;
                    break;
                }
            case 2:
                {
                    _reflect += 1;
                    break;
                }
            case 3:
                {
                    _listing += 1;
                    break;
                }
        }
    }
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
            int descision;
            if (int.TryParse(choice, out descision))
            {
                descision = int.Parse(choice);
                switch (descision)
                {
                    case 1:
                        {
                            Breathing myBreathing = new Breathing();
                            myBreathing.BreathingActivity();
                            ActivityCounter(1);
                            break;
                        }
                    case 2:
                        {
                            Reflecting myReflecting = new Reflecting();
                            myReflecting.ReflectingActivity();
                            ActivityCounter(2);
                            break;
                        }
                    case 3:
                        {
                            Listing myListing = new Listing();
                            myListing.ListingActivity();
                            ActivityCounter(3);
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
            else
            {
                Console.Clear();
                Console.WriteLine("Please type in a number 1-4.");
                Thread.Sleep(3000);
            }
        }
        Console.Clear();
        Console.WriteLine($"You did the Breathing Activity {_breathing} times today!");
        Console.WriteLine($"You did the Reflecting Activity {_reflect} times today!");
        Console.WriteLine($"You did the Listing Activity {_listing} today!");
        Console.WriteLine("\nGoodbye!\n");

    }
}