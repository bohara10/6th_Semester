using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary to store CustomerId and CustomerName
        Dictionary<int, string> customers = new Dictionary<int, string>();

        // Add entries to the dictionary
        customers.Add(101, "Rajan");
        customers.Add(102, "Sita");
        customers.Add(103, "Ram");

        // Print the contents of the dictionary
        Console.WriteLine("CustomerId\tCustomerName");
        foreach (KeyValuePair<int, string> customer in customers)
        {
            Console.WriteLine($"{customer.Key}\t\t{customer.Value}");
        }
    }
}
