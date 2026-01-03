using System;

class Employee
{
    public static string CompanyName = "TechSoft";
    public static int totalEmployees = 0;

    public readonly int Id;
    public string Name;
    public string Designation;

    public Employee(int id, string name, string designation)
    {
        this.Id = id;
        this.Name = name;
        this.Designation = designation;
        totalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    public void Display()
    {
        Console.WriteLine("Company    : " + CompanyName);
        Console.WriteLine("ID         : " + Id);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Designation: " + Designation);
    }

    static void Main()
    {
        Employee e = new Employee(1, "Amit", "Developer");

        if (e is Employee)
        {
            e.Display();
        }

        Employee.DisplayTotalEmployees();
    }
}
