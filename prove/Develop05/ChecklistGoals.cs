using System.Runtime.InteropServices;

class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonus;
    public ChecklistGoal(string _title, string _description, int _points, int timesToComplete, int bonus)
    : base(_title, _description, _points)
    {
        _timesCompleted = 0;
        _timesToComplete = timesToComplete;
        _bonus = bonus;
        _typeName = "ChecklistGoal";
    }

    public override string GetDescription()
    {
        return $"({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}";
    }

    public override int CompleteGoal()
    {
        if (_completion == true)
        {
            Console.WriteLine("You already completed this goal!");
            return 0;
        }
        else if (_timesCompleted < _timesToComplete)
        {
            _timesCompleted += 1;
            Console.WriteLine($"You completed this goal {_timesCompleted}/{_timesToComplete} times!");
            if (_timesCompleted == _timesToComplete)
            {
                _completion = true;
                return _bonus + _points;
            }
            return _points;
        }
        else //I think this code is unreachable through logic but it wouldn't run without the "All paths do not return a value"
        {
            _timesCompleted = _timesToComplete;
            _completion = true;
            Console.WriteLine("You already completed this goal!"); //Just in case something weird happens I have this here, if somehow completion wasn't marked true
            return 0;
        }
    }

    public override string GetSaveString()
    {
        return $"{base.GetSaveString()}, {_timesToComplete}, {_timesCompleted}, {_bonus}";
    }

    public override void MarkComplete()
    {
        _completion = true;
        _timesCompleted = _timesToComplete;
    }
    public void GetAmount(int input)
    {
        _timesCompleted = input;
    }

}