using System;

class Student
{
    public int rollNumber;
    protected string name;
    private double cgpa;

    public void SetCGPA(double c)
    {
        cgpa = c;
    }

    public double GetCGPA()
    {
        return cgpa;
    }
}

class PostgraduateStudent : Student
{
    public void Display()
    {
        Console.WriteLine("Name : " + name);
    }

    static void Main()
    {
        PostgraduateStudent s = new PostgraduateStudent();
        s.rollNumber = 1;
        s.name = "Ankit";
        s.SetCGPA(8.2);

        s.Display();
        Console.WriteLine("CGPA : " + s.GetCGPA());
    }
}
