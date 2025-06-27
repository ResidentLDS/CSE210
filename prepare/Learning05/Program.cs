using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> Shapes = new List<Shape>();

        Square shape1 = new Square("Red", 24.322);
        Shapes.Add(shape1);
        Circle shape2 = new Circle("Purple", 9.2521);
        Shapes.Add(shape2);
        Rectangle shape3 = new Rectangle("Orange", 24.325, 9.383);
        Shapes.Add(shape3);
        foreach (Shape s in Shapes)
        {
            Console.WriteLine($"The color of the shape is {s.GetColor()}, and the area is {s.GetArea()}");
        }
    }
}