using System;

// Define a delegate
delegate int AddDelegate(int a, int b);

class Calculator
{
    // Method that matches the delegate signature
    public int Add(int x, int y)
    {
        return x + y;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Create delegate instance and assign method
        AddDelegate addDel = new AddDelegate(calc.Add);

        Console.Write("Enter first digit: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second digit: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Invoke the delegate
        int result = addDel(num1, num2);

        Console.WriteLine("Sum = " + result);
    }
}
