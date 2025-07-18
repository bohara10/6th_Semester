using System;

class Animal
{
    // Virtual method
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    // Overriding the virtual method
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    // Overriding the virtual method
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main()
    {
        // Base class reference to derived class objects
        Animal a;

        a = new Dog();
        a.Speak();   // Output: The dog barks.

        a = new Cat();
        a.Speak();   // Output: The cat meows.

        a = new Animal();
        a.Speak();   // Output: The animal makes a sound.
    }
}
