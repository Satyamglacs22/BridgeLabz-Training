using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Vehicle_Rental_System
{
    

    public abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        protected double rentalRate;

        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    vehicleNumber = value;
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    type = value;
            }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set
            {
                if (value > 0)
                    rentalRate = value;
            }
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Vehicle No   : " + VehicleNumber);
            Console.WriteLine("Vehicle Type : " + Type);
            Console.WriteLine("Rate / Day   : " + RentalRate);
        }
    }


}
