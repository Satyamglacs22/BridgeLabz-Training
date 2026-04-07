using System;

namespace Fitness_Tracker
{
    public class Program
    {
        public static void Main()
        {
            Userprofile user = new Userprofile();

            Console.Write("Enter Name: ");
            user.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            user.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Gender: ");
            user.Gender = Console.ReadLine();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- FitTrack Menu ---");
                Console.WriteLine("1. Add Cardio Workout");
                Console.WriteLine("2. Add Strength Workout");
                Console.WriteLine("3. View Workout History");
                Console.WriteLine("4. View Total Calories");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CardioWorkout cardio = new CardioWorkout();
                        cardio.WorkoutName = "Cardio";

                        Console.Write("Enter Duration (mins): ");
                        cardio.Duration = int.Parse(Console.ReadLine());

                        Console.Write("Enter Distance (km): ");
                        cardio.Distance = double.Parse(Console.ReadLine());

                        cardio.CalculateCalories();
                        cardio.TrackWorkout();
                        user.AddWorkout(cardio);
                        break;

                    case 2:
                        StrengthWorkout strength = new StrengthWorkout();
                        strength.WorkoutName = "Strength";

                        Console.Write("Enter Duration (mins): ");
                        strength.Duration = int.Parse(Console.ReadLine());

                        Console.Write("Enter Sets: ");
                        strength.Sets = int.Parse(Console.ReadLine());

                        Console.Write("Enter Reps: ");
                        strength.Reps = int.Parse(Console.ReadLine());

                        strength.CalculateCalories();
                        strength.TrackWorkout();
                        user.AddWorkout(strength);
                        break;

                    case 3:
                        user.ShowWorkouts();
                        break;

                    case 4:
                        user.ShowTotalCalories();
                        break;

                    case 0:
                        exit = true;
                        break;
                }
            }
        }
    }
}
