using System;

// Base class
class Employee
{
    public string name;
    public int id;
    public double salary;

    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

// Manager class
class Manager : Employee
{
    public int teamSize;

    public void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + teamSize);
    }
}

// Developer class
class Developer : Employee
{
    public string language;

    public void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Language: " + language);
    }
}

// Intern class
class Intern : Employee
{
    public string duration;

    public void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + duration);
    }
}

class Employee1
{
    static void Main()
    {
        Manager m = new Manager();
        m.name = "Amit";
        m.id = 1;
        m.salary = 50000;
        m.teamSize = 5;
        m.DisplayDetails();
    }
}
