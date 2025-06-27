using System.Drawing;

public class Rectangle : Shape
{
    private double Length;
    private double Width;

    public Rectangle(string _color, double _length, double _width)
    : base(_color)
    {
        Length = _length;
        Width = _width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}