using System;

class HotelBooking
{
    public string guestName;
    public string roomType;
    public int nights;

    // Default constructor
    public HotelBooking()
    {
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string g, string r, int n)
    {
        guestName = g;
        roomType = r;
        nights = n;
    }

    // Copy constructor
    public HotelBooking(HotelBooking hb)
    {
        guestName = hb.guestName;
        roomType = hb.roomType;
        nights = hb.nights;
    }

    public void Display()
    {
        Console.WriteLine("Guest Name : " + guestName);
        Console.WriteLine("Room Type  : " + roomType);
        Console.WriteLine("Nights     : " + nights);
    }

    static void Main()
    {
        HotelBooking b1 = new HotelBooking();
        HotelBooking b2 = new HotelBooking("Rahul", "Deluxe", 3);
        HotelBooking b3 = new HotelBooking(b2);

        b1.Display();
        Console.WriteLine();
        b2.Display();
        Console.WriteLine();
        b3.Display();
    }
}
