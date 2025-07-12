class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points)
    : base(title, description, points)
    {
        _typeName = "SimpleGoal";
    }
    public override int CompleteGoal()
    {
        if (_completion == false)
        {
            _completion = true;
            return _points;
        }
        else
        {
            Console.WriteLine("You've already completed this goal!");
            return 0;
        }
    }
    public override void MarkComplete()
    {
        _completion = true;
    }
}