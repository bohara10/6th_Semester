using System;

class Student
{
    // Automatic properties
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        // Creating a student object
        Student student = new Student
        {
            Id = 101,
            Name = "Aarav Sharma"
        };

        // Displaying student details
        Console.WriteLine("Student Details:");
        Console.WriteLine($"ID: {student.Id}");
        Console.WriteLine($"Name: {student.Name}");
    }
}
