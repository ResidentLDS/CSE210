class Outdoors : Event
{
    private string _forcast;
    public Outdoors(string title, string description, string date, string time,
    string address, string forcast)
    : base(title, description, date, time, address)
    {
        _eventType = "Outdoor";
        _forcast = forcast;
    }

    public override void SpecialDetails()
    {
        Console.WriteLine($"Weather - {_forcast}");
    }
    
}