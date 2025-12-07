using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square(22.5, "blue"));
        shapes.Add(new Rectangle(19.8, 7.9, "yellow"));
        shapes.Add(new Circle(22.5, "green"));

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine(area);
            
            string color = shape.GetColor();
            Console.WriteLine(color);
        }
    }
}