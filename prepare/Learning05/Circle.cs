using System.Dynamic;

public class Circle : Shape
{
    private double Radius;
    public Circle(string _color, double _radius)
    : base(_color)
    {
        Radius = _radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}