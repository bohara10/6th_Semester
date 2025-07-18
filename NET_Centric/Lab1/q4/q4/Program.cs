using System;

class Students
{
    private string[] studentNames = new string[10];

    // Indexer to get and set student names
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < studentNames.Length)
                return studentNames[index];
            else
                return "Index out of range";
        }
        set
        {
            if (index >= 0 && index < studentNames.Length)
                studentNames[index] = value;
            else
                Console.WriteLine("Index out of range");
        }
    }
}

class Program
{
    static void Main()
    {
        Students students = new Students();

        // Storing student names
        students[0] = "Rajan";
        students[1] = "Sita";
        students[2] = "Ram";

        // Retrieving and displaying student names
        Console.WriteLine("Student at index 0: " + students[0]);
        Console.WriteLine("Student at index 1: " + students[1]);
        Console.WriteLine("Student at index 2: " + students[2]);

        // Trying to access an invalid index
        Console.WriteLine("Student at index 10: " + students[10]); // Index out of range
    }
}
