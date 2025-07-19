class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public Lectures(string title, string description, string date, string time,
    string address, string speaker, int capacity)
    : base(title, description, date, time, address)
    {
        _eventType = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void SpecialDetails()
    {
        Console.WriteLine($"Speaker: {_speaker} -Capacity- {_capacity}");
    }
}