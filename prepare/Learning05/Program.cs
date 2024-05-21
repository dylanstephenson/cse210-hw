using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        Rectangle rectangle = new Rectangle("red", 6, 8);
        Circle circle = new Circle("green", 7);

        List<Shape> shapes = new List<Shape>() {square, rectangle, circle};

        foreach (Shape shape in shapes)
        {
            string shapeColor = shape.GetColor();
            double shapeArea = shape.GetArea();

            Console.WriteLine($"The color of the shape is {shapeColor} and the area of the shape is {shapeArea}");
        }
    }
}