using System;

// Superclass
class Animal
{
    public string name;
    public int age;

    // Virtual method
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Subclass Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Subclass Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Subclass Bird
class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class AnimalMain
{
    static void Main()
    {
        Animal a1 = new Dog();
        Animal a2 = new Cat();
        Animal a3 = new Bird();

        a1.MakeSound();
        a2.MakeSound();
        a3.MakeSound();
    }
}
