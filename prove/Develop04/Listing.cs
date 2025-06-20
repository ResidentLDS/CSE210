using System.Runtime;
using Microsoft.VisualBasic;

class Listing : Activity
{
    private string chosenPrompt;

    string[] prompts = new string[] { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    // All the different prompts it can pull from
    public Listing()
    : base("Listing Activity", "This activity will help you reflect on times in your life when you have shown strength and\nresilience.This will help you recognize the power you have and how you can\nuse it in other aspects of your life")
    {
        chosenPrompt = PickPrompt(); //I initially had this in the function "Pick prompt" but I realized I could just put this here and cut out the middle man
    }

    public void ListingActivity()
    {
        int amountOfEntries = 0;
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {chosenPrompt}---\n");
        Console.Write("You may begin in: "); PrintCounter(5);
        DateTime _currentTime = DateTime.Now;
        DateTime _endTime = _currentTime.AddSeconds(waitTime);
        while (_currentTime < _endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            amountOfEntries += 1;
        }
        Console.WriteLine(amountOfEntries);

    }

    private string PickPrompt() //Gets a random number based on the length of the prompt and returns the prompt
    {
        Random rand = new Random();
        int number = rand.Next(0, prompts.Length);
        return prompts[number];
    }
}