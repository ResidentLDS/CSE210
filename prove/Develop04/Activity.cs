class Activity
{
    private string name;
    private string description;
    protected int waitTime;
    public Activity(string _name, string _description)
    {
        name = _name;
        description = _description;
        Console.Clear();
        Console.WriteLine($"Welcome to the {name}!");
        Console.WriteLine($"\n{description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        string _entry = Console.ReadLine();
        waitTime = int.Parse(_entry);
        Console.Clear();
        Console.WriteLine("Get ready...");
        PrintSpinner(3);
    }




    protected void PrintSpinner(int _seconds)
    {
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime _endTime = currentTime.AddSeconds(_seconds);
        string animationString2 = "x+";
        while (DateTime.Now < _endTime)
        {
            Console.Write(animationString2[index++ % animationString2.Length]);
            Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.Write(" ");
    }

    protected void PrintCounter(int _seconds)
    {
        int count = _seconds;
        DateTime currentTime = DateTime.Now;
        DateTime _endTime = currentTime.AddSeconds(_seconds);
        while (DateTime.Now < _endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write(" ");
    }

    protected void ReturnCongrats()
    {
        Console.WriteLine("\nWell Done!!");
        PrintSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {waitTime} seconds of the Breathing Activity.");
        PrintSpinner(6);
    }

    protected int PickPrompt(int prompts) //Gets a random number based on the length of the prompt and returns the prompt
    {
        Random rand = new Random();
        int number = rand.Next(0, prompts);
        return number;
    }

    protected void BeginIn()
    {
        Console.Write("You may begin in: "); PrintCounter(5);
    }
}