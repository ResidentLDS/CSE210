using System.Threading.Channels;

class Reflecting : Activity
{
    private string chosenPrompt;
    private string[] reflectionPrompts = new string[] //Initial prompts to ask
{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
};
    private List<string> prompts;

    public Reflecting()
    : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        prompts = new List<string> //I put the list in here so that it could be edited each time this is called and it refreshes each time
        {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };
        chosenPrompt = reflectionPrompts[PickPrompt(reflectionPrompts.Length)];
    }

    public void ReflectingActivity()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {chosenPrompt} --- \n");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        BeginIn();
        DateTime _currentTime = DateTime.Now;
        DateTime _endTime = _currentTime.AddSeconds(waitTime);
        Console.Clear();
        while (DateTime.Now < _endTime)
        {
            int number = PickPrompt(prompts.Count);
            Console.Write($"> {prompts[PickPrompt(prompts.Count)]}"); PrintSpinner(7);
            prompts.Remove(prompts[number]);
        }

    }

}
