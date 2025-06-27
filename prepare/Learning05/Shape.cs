using System.Drawing;

public abstract class Shape
{
    private string Color;

    public Shape(string _color)
    {
        Color = _color;
    }

    public string GetColor()
    {
        return Color;
    }

    public void SetColor(string _color)
    {
        Color = _color;
    }

    public abstract double GetArea();
}