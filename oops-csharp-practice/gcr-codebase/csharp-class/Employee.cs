using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Employee Salary: " + Salary);
    }

    static void Main()
    {
        Employee emp = new Employee();

        Console.Write("Enter Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter ID: ");
        emp.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Salary: ");
        emp.Salary = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Employee Details ---");
        emp.DisplayDetails();
    }
}
