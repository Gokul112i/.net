using System;

class Shape
{
    // Virtual method in the base class
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    // Overriding Draw() method
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape
{
    // Overriding Draw() method
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Triangle : Shape
{
    // Overriding Draw() method
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
}

class Program
{
    static void Main()
    {
        Shape shape;

        // Assign Circle object
        shape = new Circle();
        shape.Draw();

        // Assign Rectangle object
        shape = new Rectangle();
        shape.Draw();

        // Assign Triangle object
        shape = new Triangle();
        shape.Draw();
    }
}
