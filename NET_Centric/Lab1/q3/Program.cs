using System;

class Program
{
    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            // Swap elements
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Initialize array
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original Array:");
        PrintArray(array);

        // Reverse the array
        ReverseArray(array);

        Console.WriteLine("\nReversed Array:");
        PrintArray(array);

        // Keep console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}