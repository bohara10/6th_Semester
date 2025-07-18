using System;

#region Single Inheritance
// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating...");
    }
}

// Derived class (Single Inheritance)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking...");
    }
}
#endregion

#region Multiple Inheritance using Interfaces
interface IFirst
{
    void MethodA();
}

interface ISecond
{
    void MethodB();
}

// Class implementing multiple interfaces
class Multi : IFirst, ISecond
{
    public void MethodA()
    {
        Console.WriteLine("Method A from IFirst");
    }

    public void MethodB()
    {
        Console.WriteLine("Method B from ISecond");
    }
}
#endregion

#region Multilevel Inheritance
// Base class
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started...");
    }
}

// Derived from Vehicle
class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

// Derived from Car (Multilevel Inheritance)
class SportsCar : Car
{
    public void Turbo()
    {
        Console.WriteLine("SportsCar turbo mode activated...");
    }
}
#endregion

#region Hierarchical Inheritance
class Shape
{
    public void DisplayShape()
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    public void DrawCircle()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Rectangle : Shape
{
    public void DrawRectangle()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}
#endregion

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Single Inheritance ===");
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        Console.WriteLine("\n=== Multiple Inheritance using Interfaces ===");
        Multi multi = new Multi();
        multi.MethodA();
        multi.MethodB();

        Console.WriteLine("\n=== Multilevel Inheritance ===");
        SportsCar sportsCar = new SportsCar();
        sportsCar.Start();
        sportsCar.Drive();
        sportsCar.Turbo();

        Console.WriteLine("\n=== Hierarchical Inheritance ===");
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        circle.DisplayShape();
        circle.DrawCircle();
        rectangle.DisplayShape();
        rectangle.DrawRectangle();
    }
}
