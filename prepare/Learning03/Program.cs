using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int number)
    {
        _topNumber = number;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public void GetFractionString()
    {
        string printed = $"{_topNumber / _bottomNumber}";
        Console.WriteLine(printed);
    }

    public void GetDecimalValue()
    {
        int division = _topNumber / _bottomNumber;
        Console.WriteLine($"{division}");
    }
}

