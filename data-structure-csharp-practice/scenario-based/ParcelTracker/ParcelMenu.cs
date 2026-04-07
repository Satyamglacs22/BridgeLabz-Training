using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracker
{
    internal class ParcelMenu
    {
        private ParcelUtility utility = new ParcelUtility();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Parcel Tracker Menu ---");
                Console.WriteLine("1. Create Default Stages");
                Console.WriteLine("2. Track Parcel");
                Console.WriteLine("3. Add Custom Checkpoint");
                Console.WriteLine("4. Validate Parcel");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.CreateDefaultStage();
                        break;

                    case 2:
                        utility.TrackParcel();
                        break;

                    case 3:
                        Console.Write("Enter stage after which to add checkpoint: ");
                        string afterStage = Console.ReadLine();

                        Console.Write("Enter new checkpoint name: ");
                        string newStage = Console.ReadLine();

                        utility.AddCheckpoint(afterStage, newStage);
                        break;

                    case 4:
                        utility.ValidateParcel();
                        break;

                    case 5:
                        Console.WriteLine("Exiting Parcel Tracker.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
