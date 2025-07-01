class Menu
{
    public static List<string> options = new List<string> { "Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit" };
    public static List<string> options_2 = new List<string> { "Simple Goal", "Eternal Goal", "Checklist Goal" };
    public int GoalChoice()
    {
        int count = 1;
        Console.WriteLine("The types of Goals are:");
        foreach (string choice in options_2)
        {
            Console.WriteLine($"  {count}. {choice}");
            count =+ 1;
        }
        Console.Write("Which type of goal would you like to create?");
        int response = int.Parse(Console.ReadLine());
        return response;
    }

    public int PrintMenu(bool annoyance)
    {
        int count = 1;
        Console.Clear();
        if (annoyance)
        {
            Console.WriteLine("Please select a number 1-6");
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
}