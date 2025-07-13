class Menu
{
    public static List<string> options = new List<string> { "Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Achievements", "Quit" };
    public static List<string> options_2 = new List<string> { "Simple Goal", "Eternal Goal", "Checklist Goal" };
    public int GoalChoice()
    {
        int count = 1;
        Console.WriteLine("The types of Goals are:");
        foreach (string choice in options_2)
        {
            Console.WriteLine($"  {count}. {choice}");
            count += 1;
        }
        Console.Write("Which type of goal would you like to create? ");
        int response = int.Parse(Console.ReadLine());
        return response;
    }

    public int PrintMenu(bool annoyance)
    {
        int count = 1;
        if (annoyance)
        {
            Console.WriteLine("Please select a number 1-7");
            annoyance = false;
        }
        Console.WriteLine("Menu Options:");
        foreach (string choice in options)
        {
            Console.WriteLine($"   {count}. {choice}");
            count += 1;
        }
        Console.Write("Select a choice from the menu: ");
        int response = int.Parse(Console.ReadLine());
        return response;
    }

    public Goal NewSimpleGoal()
    {
        Console.Write("What is the name of the goal? ");
        string _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int _points = int.Parse(Console.ReadLine());
        SimpleGoal Goals = new SimpleGoal(_name, _description, _points);
        return Goals;
    }

    public Goal NewChecklistGoals()
    {
        Console.Write("What is the name of the goal? ");
        string _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int _points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int _times = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int _bonus = int.Parse(Console.ReadLine());
        ChecklistGoal Goals = new ChecklistGoal(_name, _description, _points, _times, _bonus);
        return Goals;
    }

    public Goal NewEternalGoal()
    {
        Console.Write("What is the name of the goal? ");
        string _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int _points = int.Parse(Console.ReadLine());
        EternalGoal Goals = new EternalGoal(_name, _description, _points);
        return Goals;
    }

    public void GetTrophies(long points)
    {
        int next = 0;
        string[] trophies = {
            "Just getting started",
            "Got your footing yet?",
            "Warmed up",
            "Dang, keep it going",
            "Procrastination fears you!",
            "Not tired yet, are we?",
            "How much longer can this go on?",
            "Apprentice of the goal keepers",
            "Almost a pro",
            "Perserverance pays off",
            "Proficient in following through (You should try golf)",
            "You're still here?",
            "Now you're a pro",
            "Master of the goal keepers",
            "I'd say get a life but you obviously have one"};
        int[] mileStones = { 100000, 15000, 12000, 10000, 9000, 8000, 7000, 6000, 5000, 4000, 3000, 2000, 1000, 500, 250 };
        Array.Reverse(mileStones);
        int count = 1;
        for (int i = 0; i < mileStones.Length; i++)
        {
            if (mileStones[i] <= points)
            {
                Console.WriteLine($"{count}. {trophies[i]}");
                count += 1;
            }
            else
            {
                next = mileStones[i];
                break;
            }
        }
        if (count == 15)
        {
            Console.WriteLine("\nYou got every achievement! Nice Job!");
        }
        else
        {
            Console.WriteLine($"\nYour next milestone is at {next} points");
        }
    }
}