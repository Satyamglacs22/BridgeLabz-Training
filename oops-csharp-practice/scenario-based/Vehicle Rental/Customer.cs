using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental
{
    using System;

    class Customer
    {
        public string customerName;
        public string id;


        public void RentVehicle(Vehicle v, int days)
        {
            Console.WriteLine("\nCustomer Name : " + customerName);
            Console.WriteLine("Vehicle Rented:");
            v.ShowVehicleDetails();
            Console.WriteLine("Days Rented  : " + days);
            Console.WriteLine("Total Rent  : " + v.CalculateRent(days));
        }
    }

}
