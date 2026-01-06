using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental
{
    

    class Utility
    {
        static void Main()
        {
            Customer customer = new Customer();
            customer.customerName = "Satyam";
            customer.id = "2215001607";

            Bike bike = new Bike();
            Car car = new Car();
            Truck truck = new Truck();

            customer.RentVehicle(bike, 2);
            customer.RentVehicle(car, 3);
            customer.RentVehicle(truck, 1);
        }
    }

}
