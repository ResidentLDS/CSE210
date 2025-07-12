class SimpleGoal : Goal
{
    public SimpleGoal(string _title, string _description, int _points)
    : base(_title, _description, _points)
    {
        typeName = "SimpleGoal";
    }
    public override int CompleteGoal()
    {
        if (completion == false)
        {
            completion = true;
            return points;
        }
        else
        {
            Console.WriteLine("You've already completed this goal!");
            return 0;
        }
    }
    public override void MarkComplete()
    {
        completion = true;
    }
}