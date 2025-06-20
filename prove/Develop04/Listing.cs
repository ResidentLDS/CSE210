using System.Runtime;
using Microsoft.VisualBasic;

class Listing : Activity
{
    private string chosenPrompt;

    private string[] prompts = new string[] // All the different prompts it can pull from
    { 
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Listing()
    : base("Listing Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life")
    {
        chosenPrompt = prompts[PickPrompt(prompts.Length)];
    }

    public void ListingActivity()
    {
        int amountOfEntries = 0;
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {chosenPrompt} --- ");
        BeginIn();
        DateTime _currentTime = DateTime.Now;
        DateTime _endTime = _currentTime.AddSeconds(waitTime);
        Console.WriteLine();
        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            amountOfEntries += 1;
        }

        Console.WriteLine($"You listed {amountOfEntries} items!");
        ReturnCongrats();

    }

}