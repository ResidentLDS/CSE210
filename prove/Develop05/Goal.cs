class Goal
{
    private string title;
    private string description;
    private bool completion;
    private int points;

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
    public string GetDescription()
    {
        return description;
    }
    public int GetPoints()
    {
        return points;
    }
    public string GetCompletion()
    {
        if (completion == true)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
    public int CompleteGoal()
    {
        if (completion == false)
        {
            completion = true;
            return points;
        }
        else
        {
            return 0;
        }
    }

}