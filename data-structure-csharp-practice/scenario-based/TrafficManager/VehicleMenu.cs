using System;

namespace TrafficManager
{
    public class VehicleMenu
    {
        private VehicleUtility vehicleUtility;

        public VehicleMenu()
        {
            
            Console.WriteLine("Enter the Capacity of the RoundOut");
            int n = int.Parse(Console.ReadLine());
            vehicleUtility = new VehicleUtility(n);
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Traffic Manager Menu =====");
                Console.WriteLine("1. Enter Vehicle");
                Console.WriteLine("2. Exit Vehicle");
                Console.WriteLine("3. Display Traffic Status");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Vehicle ID: ");
                        int vehicleId = int.Parse(Console.ReadLine());
                        vehicleUtility.EnterVehicle(vehicleId);
                        break;

                    case 2:
                        vehicleUtility.ExitVehicle();
                        break;

                    case 3:
                        vehicleUtility.DisplayStatus();
                        break;

                    case 4:
                        Console.WriteLine("Exiting Traffic Manager...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
