using System;

class Addition
{
    private int number1;
    private int number2;

    // Constructor to initialize the numbers
    public Addition(int num1, int num2)
    {
        number1 = num1;
        number2 = num2;
    }

    // Method to calculate the sum  
    public int GetSum()
    {
        return number1 + number2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input two numbers from the user
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Create an object of the Addition class
        Addition addition = new Addition(num1, num2);

        // Display the sum
        Console.WriteLine("The sum of the two numbers is: " + addition.GetSum());
    }
}
