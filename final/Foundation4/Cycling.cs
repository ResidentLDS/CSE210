class Cycling : Activity
{
    private double _speed;
    public Cycling(double speed, double time, string date)
    : base (time, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * MinutesToHours();
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    } 

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min)- Distance {GetDistance():F2} miles, Average Speed: {_speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }
}