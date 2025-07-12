class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points)
    : base(title, description, points)
    {
        _typeName = "EternalGoal";
    }

    public override string GetCompletion()
    {
        return "[ ]";//Eternal Goals should never not be completed thus it always says this.
    }

    public override int CompleteGoal()
    {
        _completion = false; //Just to make sure that it never completes somehow (IDK how it would) it always sets completion to false
        return _points;
    }
}