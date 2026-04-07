using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Vehicle_Rental_System
{
    public class Car : Vehicle, IInsurable
    {
        public Car(double rate)
        {
            RentalRate = rate;
            Type = "Car";
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance - Premium Plan";
        }
    }


}
