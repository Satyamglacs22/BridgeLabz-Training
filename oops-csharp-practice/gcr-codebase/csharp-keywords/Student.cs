using System;

class Student
{
    public static string UniversityName = "ABC University";
    public static int totalStudents = 0;

    public readonly int RollNumber;
    public string Name;
    public string Grade;

    public Student(int roll, string name, string grade)
    {
        this.RollNumber = roll;
        this.Name = name;
        this.Grade = grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    public void Display()
    {
        Console.WriteLine("University : " + UniversityName);
        Console.WriteLine("Roll No    : " + RollNumber);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Grade      : " + Grade);
    }

    static void Main()
    {
        Student s = new Student(1, "Neha", "A");

        if (s is Student)
        {
            s.Display();
        }

        Student.DisplayTotalStudents();
    }
}
