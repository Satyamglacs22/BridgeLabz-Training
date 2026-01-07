using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Vehicle_Rental_System
{
    public class Truck : Vehicle, IInsurable
    {
        public Truck(double rate)
        {
            RentalRate = rate;
            Type = "Truck";
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 2000;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance - Commercial Plan";
        }
    }

}
