using System;

class Vehicle
{
    public static int RegistrationFee = 5000;

    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string regNo, string owner, string type)
    {
        this.RegistrationNumber = regNo;
        this.OwnerName = owner;
        this.VehicleType = type;
    }

    public static void UpdateRegistrationFee(int fee)
    {
        RegistrationFee = fee;
    }

    public void Display()
    {
        Console.WriteLine("Reg No : " + RegistrationNumber);
        Console.WriteLine("Owner  : " + OwnerName);
        Console.WriteLine("Type   : " + VehicleType);
        Console.WriteLine("Fee    : " + RegistrationFee);
    }

    static void Main()
    {
        Vehicle v = new Vehicle("BR01AB1234", "Ravi", "Bike");

        if (v is Vehicle)
        {
            v.Display();
        }
    }
}
