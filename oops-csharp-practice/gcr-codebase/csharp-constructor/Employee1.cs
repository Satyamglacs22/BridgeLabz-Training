using System;

class Employee1
{
    public int employeeID;
    protected string department;
    private double salary;

    public void SetSalary(double s)
    {
        salary = s;
    }
}

class Manager : Employee1
{
    public void Display()
    {
        Console.WriteLine(employeeID + " - " + department);
    }

    static void Main()
    {
        Manager m = new Manager();
        m.employeeID = 101;
        m.department = "IT";
        m.SetSalary(50000);

        m.Display();
    }
}
