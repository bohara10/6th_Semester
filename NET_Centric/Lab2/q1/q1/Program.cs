using System;

class Program
{
    static void Main()
    {
        string original = "Hello";
        Console.WriteLine("Original string: " + original);

        // Try to change the string
        string modified = original.Replace("H", "Y");

        Console.WriteLine("After Replace method:");
        Console.WriteLine("Original string: " + original);   // Still "Hello"
        Console.WriteLine("Modified string: " + modified);   // "Yello"

        // Check reference equality
        Console.WriteLine("\nAre both strings pointing to the same memory? " + object.ReferenceEquals(original, modified));
    }
}
