using System;
using System.Collections.Generic; // Required for List<T>

class Program
{
    static void Main()
    {
        // Create a generic list of integers
        List<int> numbers = new List<int>();

        // Add numbers 1 to 10 into the list
        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }

        // Print the numbers
        Console.WriteLine("Numbers from 1 to 10:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
