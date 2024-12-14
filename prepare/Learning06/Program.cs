using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 3.2);
        shapes.Add(square);

        Circle circle = new Circle("yellow", 3.2);
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle("blue", 3.2, 5.6);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:f2}.");
        }
    }
}