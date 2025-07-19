class Swimming : Activity
{
    private double _numberOfLaps;
    public Swimming(double numberOfLaps, double time, string date)
    : base (time, date)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * (50.0 / 1000.0) * 0.62;  //For some reason this would only work if I had decimals by the numbers, 
                                                        // so I did it to all of them. I actually got it to tell me infinity min per mile somehow
    }

    public override double GetSpeed()
    {
        return 60.0*(GetDistance()/_length);
    }

    public override double GetPace()
    {
        return 60.0/GetSpeed();
    }
    
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length} min)- Distance {GetDistance():F2} miles, Average Speed: {GetSpeed():F2}, Pace: {GetPace():F2} min per mile";
    }
}