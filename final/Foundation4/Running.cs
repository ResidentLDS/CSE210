using System.Dynamic;

class Running : Activity
{
    private double _distance;
    public Running(double distance, double time, string date)
    : base(time, date)
    {
        _distance = distance;
    }
    public override double GetSpeed()
    {
        return _distance / _length * 60.0;
    }
    public override double GetPace()
    {
        return _length / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min)- Distance {_distance:F2} miles, Average Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}