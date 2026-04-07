using System;

class Course
{
    public string courseName;
    public int duration;
    public double fee;

    public static string instituteName = "ABC Institute";

    public void Display()
    {
        Console.WriteLine(courseName + " | " + duration + " | " + fee);
    }

    public static void UpdateInstitute(string name)
    {
        instituteName = name;
    }

    static void Main()
    {
        Course c = new Course();
        c.courseName = "C#";
        c.duration = 3;
        c.fee = 5000;

        c.Display();
        Course.UpdateInstitute("XYZ Institute");
    }
}
