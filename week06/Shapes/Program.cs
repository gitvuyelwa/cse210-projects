using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s = new Square("Red", 5);
        shapes.Add(s);

        Rectangle r = new Rectangle("Blue", 4, 6);
        shapes.Add(r);

        Circle c = new Circle("Green", 3);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}