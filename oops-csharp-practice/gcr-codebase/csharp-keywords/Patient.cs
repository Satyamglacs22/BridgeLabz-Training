using System;

class Patient
{
    public static string HospitalName = "City Hospital";
    public static int totalPatients = 0;

    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(int id, string name, int age, string ailment)
    {
        this.PatientID = id;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        totalPatients++;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    public void Display()
    {
        Console.WriteLine("Hospital : " + HospitalName);
        Console.WriteLine("ID       : " + PatientID);
        Console.WriteLine("Name     : " + Name);
        Console.WriteLine("Age      : " + Age);
        Console.WriteLine("Ailment  : " + Ailment);
    }

    static void Main()
    {
        Patient p = new Patient(1, "Suman", 30, "Fever");

        if (p is Patient)
        {
            p.Display();
        }

        Patient.GetTotalPatients();
    }
}
