using System;

class Device
{
    public string deviceId;
    public string status;
}

class Thermostat : Device
{
    public int temperature;

    public void DisplayStatus()
    {
        Console.WriteLine(deviceId + " - " + status);
        Console.WriteLine("Temp: " + temperature);
    }
}

class Device1
{
    static void Main()
    {
        Thermostat t = new Thermostat();
        t.deviceId = "D101";
        t.status = "ON";
        t.temperature = 24;

        t.DisplayStatus();
    }
}
