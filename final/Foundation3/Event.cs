class Event
{
    protected string _eventType;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time,
    string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(address);
    }


    public void GetShortDescription()
    {
        Console.WriteLine($"-{_eventType}-\n{_title}: {_date}");
    }

    public void GetStandardDetails()
    {
        Console.WriteLine($"{_title}: {_description}\n{_time} on {_date}");
    }

    public void GetFullDetails()
    {
        GetStandardDetails(); //I realized what I was typing here matched what I wanted from the short description perfectly so I did this instead.
        Console.WriteLine($"{_date}, {_time},\nAddress: {_address.PrintAddress()}");
        SpecialDetails();
    }

    public virtual void SpecialDetails()
    {

    }
}