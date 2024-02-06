using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("red", 6, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("yellow", 10);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string colors = shape.GetColor();
            double areas = shape.GetArea();
            Console.WriteLine($"The {colors} shape has an area of {areas}.");
        }
    }
}