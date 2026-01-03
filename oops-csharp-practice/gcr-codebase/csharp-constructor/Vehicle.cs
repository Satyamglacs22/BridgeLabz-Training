using System;

class Vehicle
{
    public string ownerName;
    public string vehicleType;

    public static int registrationFee = 5000;

    public void Display()
    {
        Console.WriteLine(ownerName + " - " + vehicleType);
    }

    public static void UpdateFee(int fee)
    {
        registrationFee = fee;
    }

    static void Main()
    {
        Vehicle v = new Vehicle();
        v.ownerName = "Rohit";
        v.vehicleType = "Bike";

        v.Display();
        Vehicle.UpdateFee(6000);
    }
}
