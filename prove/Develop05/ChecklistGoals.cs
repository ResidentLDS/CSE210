using System.Runtime.InteropServices;

class ChecklistGoal : Goal
{
    private int timesToComplete;
    private int timesCompleted;
    private int bonus;
    public ChecklistGoal(string _title, string _description, int _points, int _timesToComplete, int _bonus)
    : base(_title, _description, _points)
    {
        timesCompleted = 0;
        timesToComplete = _timesToComplete;
        bonus = _bonus;
        typeName = "ChecklistGoal";
    }

    public override string GetDescription()
    {
        return $"({description}) -- Currently completed: {timesCompleted}/{timesToComplete}";
    }

    public override int CompleteGoal()
    {
        if (completion == true)
        {
            Console.WriteLine("You already completed this goal!");
            return 0;
        }
        else if (timesCompleted < timesToComplete)
        {
            timesCompleted += 1;
            Console.WriteLine($"You completed this goal {timesCompleted}/{timesToComplete} times!");
            if (timesCompleted == timesToComplete)
            {
                completion = true;
                return bonus + points;
            }
            return points;
        }
        else //I think this code is unreachable through logic but it wouldn't run without the "All paths do not return a value"
        {
            timesCompleted = timesToComplete;
            completion = true;
            Console.WriteLine("You already completed this goal!"); //Just in case something weird happens I have this here, if somehow completion wasn't marked true
            return 0;
        }
    }

    public override string GetSaveString()
    {
        return $"{base.GetSaveString()}, {timesToComplete}, {timesCompleted}, {bonus}";
    }

    public override void MarkComplete()
    {
        completion = true;
        timesCompleted = timesToComplete;
    }
    public void GetAmount(int input)
    {
        timesCompleted = input;
    }

}