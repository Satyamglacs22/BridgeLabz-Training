using System;

// Superclass
class Person
{
    public string name;
    public int age;
}

// Teacher class
class Teacher : Person
{
    public string subject;

    public void DisplayRole()
    {
        Console.WriteLine("Role   : Teacher");
        Console.WriteLine("Name   : " + name);
        Console.WriteLine("Age    : " + age);
        Console.WriteLine("Subject: " + subject);
    }
}

// Student class
class Student : Person
{
    public string grade;

    public void DisplayRole()
    {
        Console.WriteLine("Role : Student");
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age  : " + age);
        Console.WriteLine("Grade: " + grade);
    }
}

// Staff class
class Staff : Person
{
    public string job;

    public void DisplayRole()
    {
        Console.WriteLine("Role : Staff");
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age  : " + age);
        Console.WriteLine("Job  : " + job);
    }
}

class Person1
{
    static void Main()
    {
        Teacher t = new Teacher();
        t.name = "Kailash Nath Yadav";
        t.age = 45;
        t.subject = "Maths";
        t.DisplayRole();

        Console.WriteLine();

        Student s = new Student();
        s.name = "Satyam";
        s.age = 23;
        s.grade = "A";
        s.DisplayRole();

        Console.WriteLine();

        Staff st = new Staff();
        st.name = "Prateek Singh YashWardhan";
        st.age = 23;
        st.job = "Sweeper";
        st.DisplayRole();
    }
}
