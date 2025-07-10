class Goal
{
    protected string title;
    protected string description;
    protected bool completion;
    protected int points;

    public Goal(string _title, string _description, int _points)
    {
        title = _title;
        description = _description;
        points = _points;
        completion = false;
    }
    public string GetTitle()
    {
        return title;
    }
    public virtual string GetDescription()
    {
        return $"({description})";
    }
    public int GetPoints()
    {
        return points;
    }
    public virtual string GetCompletion()
    {
        return "[ ]";
    }
    public virtual int CompleteGoal()
    {
        return 0;
    }

}