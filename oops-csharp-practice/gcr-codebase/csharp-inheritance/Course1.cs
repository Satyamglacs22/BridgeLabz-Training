using System;

class Course
{
    public string courseName;
}

class OnlineCourse : Course
{
    public string platform;
}

class PaidOnlineCourse : OnlineCourse
{
    public int fee;

    public void Display()
    {
        Console.WriteLine(courseName + " - " + platform + " - " + fee);
    }
}

class Course1
{
    static void Main()
    {
        PaidOnlineCourse c = new PaidOnlineCourse();
        c.courseName = "C#";
        c.platform = "Udemy";
        c.fee = 2000;

        c.Display();
    }
}
