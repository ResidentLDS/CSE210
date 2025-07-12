using System.Numerics;

class Goal
{
    protected string _title;
    protected string _description;
    protected bool _completion;
    protected int _points;
    protected string _typeName;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
        _completion = false;
    }
    public string GetTitle()
    {
        return _title;
    }
    public virtual string GetDescription()
    {
        return $"({_description})";
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual string GetCompletion()
    {
        if (_completion == true)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
    public virtual int CompleteGoal()
    {
        return 0;
    }

    public virtual string GetSaveString()
    {
        return $"{_typeName}, {_title}, {_description}, {_points}, {_completion}";
    }

    public virtual void MarkComplete()
    {
    }
}