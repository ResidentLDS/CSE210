class Receptions : Event
{
    private string _email;
    public Receptions(string title, string description, string date, string time,
    string address, string email)
    : base(title, description, date, time, address)
    {
        _eventType = "Reception";
        _email = email;
    }

    public override void SpecialDetails()
    {
        Console.WriteLine($"RSVP at {_email}");
    }
}