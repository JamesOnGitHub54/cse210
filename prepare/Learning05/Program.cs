using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq1 = new Square("Maroon", 2);
        shapes.Add(sq1);

        Circle c1 = new Circle("Gold", 3);
        shapes.Add(c1);

        Rectangle r1 = new Rectangle("Copper", 2, 3);
        shapes.Add(r1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}