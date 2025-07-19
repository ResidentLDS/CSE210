class Activity
{
    protected string _date;
    protected double _length;
    public Activity(double time, string date)
    {
        _length = time;
        _date = date;
    }

    public double MinutesToHours()
    {
        return _length / 60.0; 
    }
    public virtual double GetSpeed()
    {
        return 123.45;
    }
    public virtual double GetPace()
    {
        return 123.45;
    }
    public virtual double GetDistance()
    {
        return 123.45;
    }
    public virtual string GetSummary()
    {
        return "Can I get an f in the chat boys?";
    }
}