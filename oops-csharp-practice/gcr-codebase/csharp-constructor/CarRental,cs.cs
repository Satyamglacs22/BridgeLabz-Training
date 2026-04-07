using System;

class CarRental
{
    public string customerName;
    public string carModel;
    public int rentalDays;

    public CarRental(string c, string m, int d)
    {
        customerName = c;
        carModel = m;
        rentalDays = d;
    }

    public void CalculateCost()
    {
        int costPerDay = 1000;
        Console.WriteLine("Total Cost : " + (rentalDays * costPerDay));
    }

    static void Main()
    {
        CarRental cr = new CarRental("Aman", "Swift", 4);
        cr.CalculateCost();
    }
}
