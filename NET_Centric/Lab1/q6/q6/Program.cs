using System;

// Interface for dimensions
interface IDimensions
{
    void SetDimensions(double length, double breadth);
}

// Interface for area calculation
interface IArea
{
    double CalculateArea();
}

// Class implementing multiple interfaces
class Rectangle : IDimensions, IArea
{
    private double length;
    private double breadth;

    public void SetDimensions(double length, double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }

    public double CalculateArea()
    {
        return length * breadth;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle();

        Console.Write("Enter length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth: ");
        double breadth = Convert.ToDouble(Console.ReadLine());

        rect.SetDimensions(length, breadth);
        double area = rect.CalculateArea();

        Console.WriteLine("Area of Rectangle = " + area);
    }
}
