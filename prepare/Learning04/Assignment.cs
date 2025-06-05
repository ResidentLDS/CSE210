class Assignment
{
    private string _studentName;
    private string _topic;

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}