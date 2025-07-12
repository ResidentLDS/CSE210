class EternalGoal : Goal
{
    public EternalGoal(string _title, string _description, int _points)
    : base(_title, _description, _points)
    {
        typeName = "EternalGoal";
    }

    public override string GetCompletion()
    {
        return "[ ]";//Eternal Goals should never not be completed thus it always says this.
    }

    public override int CompleteGoal()
    {
        completion = false; //Just to make sure that it never completes somehow (IDK how it would) it always sets completion to false
        return points;
    }
}