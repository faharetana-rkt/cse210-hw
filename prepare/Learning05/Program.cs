using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2.5, "Blue");
        //Console.WriteLine(square.GetColor());
        //Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(10, 5, "Red");
        //Console.WriteLine(rectangle.GetColor());
        //Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle(6.5, "Black");
        //Console.WriteLine(circle.GetColor());
        //Console.WriteLine(circle.GetArea());

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine($"The Color is {shape.GetColor()} and the area is {shape.GetArea()}");
        }
    }
}