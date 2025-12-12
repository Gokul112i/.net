using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Add(double a, double b, double c)
    {
        return a + b + c;
    }


    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }


    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("===== Calculator Overloading Demo =====");

        Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
        Console.WriteLine("Add(int, int, int): " + calc.Add(5, 10, 15));
        Console.WriteLine("Add(double, double): " + calc.Add(5.5, 10.2));
        Console.WriteLine("Add(double, double, double): " + calc.Add(1.1, 2.2, 3.3));

        Console.WriteLine("\nMultiply(int, int): " + calc.Multiply(4, 5));
        Console.WriteLine("Multiply(int, int, int): " + calc.Multiply(2, 3, 4));
        Console.WriteLine("Multiply(double, double): " + calc.Multiply(2.5, 3.2));

        Console.WriteLine("\nSubtract(int, int): " + calc.Subtract(20, 5));
        Console.WriteLine("Subtract(double, double): " + calc.Subtract(10.5, 4.2));

        Console.WriteLine("\n=======================================");
    }
}
