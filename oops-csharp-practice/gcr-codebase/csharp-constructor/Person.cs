using System;

class Person
{
    public string name;
    public int age;

    // Parameterized constructor
    public Person(string n, int a)
    {
        name = n;
        age = a;
    }

    // Copy constructor
    public Person(Person p)
    {
        name = p.name;
        age = p.age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        Person p1 = new Person("Amit", 22);
        Person p2 = new Person(p1);

        p2.Display();
    }
}
