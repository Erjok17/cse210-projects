using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");

        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 4),
            new Rectangle("Blue", 5, 6),
            new Circle("Green", 3)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea():F2}");
            Console.WriteLine();
        }
    }
}