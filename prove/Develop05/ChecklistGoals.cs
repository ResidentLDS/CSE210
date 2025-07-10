using System.Runtime.InteropServices;

class ChecklistGoal : Goal
{
    int timesToComplete;
    int timesCompleted;
    int bonus;
    public ChecklistGoal(string _title, string _description, int _points, int _timesToComplete, int _bonus)
    : base(_title, _description, _points)
    {
        timesCompleted = 0;
        timesToComplete = _timesToComplete;
        bonus = _bonus;
    }

    public override string GetDescription()
    {
        return $"({description}) -- Currently completed: {timesToComplete}/{timesCompleted}";
    }

    public override int CompleteGoal()
    {
        if (timesCompleted < timesToComplete)
        {
            timesCompleted += 1;
            return points;
        }
        else if (timesCompleted == timesToComplete)
        {
            if (completion == true)
            {
                Console.WriteLine("You already completed this goal!");
                return 0;
            }
            else
            {
                completion = true;
                return bonus;
            }
        }
        else //I decided to leave this here more as a fail safe just in case somehow it doesn't work propperly
        {
            Console.WriteLine("You've already completed this goal!");
            return 0;
        }
    }
}