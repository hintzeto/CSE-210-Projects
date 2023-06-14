using System;

class Program
{
    static void Main(string[] args)
    {
        // Square square = new Square(2, "red");

        // Console.WriteLine(square.GetArea());
        // Console.WriteLine(square.GetColor());

        // Rectangle rectangle = new Rectangle(2,4,"blue");
        // Circle circle = new Circle(75, "orange");

        // Console.WriteLine($"Area: {rectangle.GetArea()}\nColor: {rectangle.GetColor()}");

        // Console.WriteLine($"Area: {circle.GetArea()}\nColor: {circle.GetColor()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle(2, 4, "Orange"));
        shapes.Add(new Circle(755, "Blue"));
        shapes.Add(new Square(2, "Red"));

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color}\nArea: {area}");
        }
    }
}