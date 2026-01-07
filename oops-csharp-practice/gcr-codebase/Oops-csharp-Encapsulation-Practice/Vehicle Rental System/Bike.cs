using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Vehicle_Rental_System
{
    public class Bike : Vehicle, IInsurable
    {
        public Bike(double rate)
        {
            RentalRate = rate;
            Type = "Bike";
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 300;
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance - Basic Plan";
        }
    }

}
