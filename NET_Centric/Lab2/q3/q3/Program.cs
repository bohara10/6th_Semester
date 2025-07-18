using System;

// Define the interface
interface ICalculator
{
    double Add(double a, double b);
    double Subtract(double a, double b);
    double Multiply(double a, double b);
    double Divide(double a, double b);
}

// Implement the interface
class SimpleCalculator : ICalculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return double.NaN;
        }
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        ICalculator calc = new SimpleCalculator();

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nResults:");
        Console.WriteLine("Addition: " + calc.Add(num1, num2));
        Console.WriteLine("Subtraction: " + calc.Subtract(num1, num2));
        Console.WriteLine("Multiplication: " + calc.Multiply(num1, num2));
        Console.WriteLine("Division: " + calc.Divide(num1, num2));
    }
}
