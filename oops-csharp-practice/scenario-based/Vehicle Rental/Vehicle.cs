using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental
{
    class Vehicle : IRentable
    {
        protected string vehicleName;
        protected int rentPerDay;
        protected int mileage;

        public virtual int CalculateRent(int days)
        {
            return rentPerDay * days;
        }

        public void ShowVehicleDetails()
        {
            Console.WriteLine("Vehicle Name : " + vehicleName);
            Console.WriteLine("Mileage      : " + mileage + " km/l");
            Console.WriteLine("Rent/Day     : " + rentPerDay);
        }
    }

}
