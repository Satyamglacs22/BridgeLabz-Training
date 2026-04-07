using System;

// Base class
class Vehicle
{
    public int maxSpeed;
    public string fuelType;

    // Virtual method
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Speed: " + maxSpeed);
        Console.WriteLine("Fuel: " + fuelType);
    }
}

// Car class
class Car : Vehicle
{
    public int seats;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seats: " + seats);
    }
}

// Truck class
class Truck : Vehicle
{
    public int load;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Load: " + load);
    }
}

// Motorcycle class
class Motorcycle : Vehicle
{
    public bool sideCar;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("SideCar: " + sideCar);
    }
}

class Vehicle1
{
    static void Main()
    {
        Vehicle[] v = new Vehicle[3];

        v[0] = new Car { maxSpeed = 120, fuelType = "Petrol", seats = 4 };
        v[1] = new Truck { maxSpeed = 80, fuelType = "Diesel", load = 500 };
        v[2] = new Motorcycle { maxSpeed = 100, fuelType = "Petrol", sideCar = false };

        for (int i = 0; i < v.Length; i++)
        {
            v[i].DisplayInfo();
            Console.WriteLine();
        }
    }
}
