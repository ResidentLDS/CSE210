class ChecklistGoal : Goal
{
    int timesToComplete;
    int timesCompleted;
    public ChecklistGoal(string _title, string _description, int _points, int _timesToComplete)
    : base(_title, _description, _points)
    {
        timesCompleted = 0;
        timesToComplete = _timesToComplete;
    }
}