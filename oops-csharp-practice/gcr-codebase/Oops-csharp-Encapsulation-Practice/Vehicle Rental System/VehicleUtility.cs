using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Vehicle_Rental_System
{
    

    public class VehicleUtility
    {
        public void Run()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle car = new Car(1500)
            {
                VehicleNumber = "MH12AB1234"
            };

            Vehicle bike = new Bike(500)
            {
                VehicleNumber = "MH14XY5678"
            };

            Vehicle truck = new Truck(3000)
            {
                VehicleNumber = "MH10TR9999"
            };

            vehicles.Add(car);
            vehicles.Add(bike);
            vehicles.Add(truck);

            int days = 3;

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayVehicleDetails();

                Console.WriteLine("Rental Cost : " +
                    vehicle.CalculateRentalCost(days));

                if (vehicle is IInsurable)
                {
                    IInsurable insurable = (IInsurable)vehicle;
                    Console.WriteLine("Insurance   : " +
                        insurable.CalculateInsurance());
                    Console.WriteLine("Insurance Info : " +
                        insurable.GetInsuranceDetails());
                }

                Console.WriteLine("------------------------------");
            }
        }
    }


}
