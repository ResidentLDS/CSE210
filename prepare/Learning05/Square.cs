class Square : Shape
{
    private double Side;
    public Square(string _color, double _side)
    : base(_color)
    {
        Side = _side;
    }

    public override double GetArea()
    {
        return Side*Side ;
    }
}