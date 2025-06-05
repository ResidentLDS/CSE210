class MathAssignment : Assignment
{
    private string _assignment;
    public MathAssignment(string name, string topic, string assignment)
    : base(name, topic)
    {
        _assignment = assignment;
    }
    public string GetHomeworkList()
    {
        return $"{GetSummary()}{_assignment}\n";
    }
}