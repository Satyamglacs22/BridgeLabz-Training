using System;

namespace Fitness_Tracker
{
    internal class StrengthWorkout : Workout, ITrackable
    {
        public int Sets { get; set; }
        public int Reps { get; set; }

        public int CalculateCalories()
        {
            Calories = Sets * Reps * 5;
            return Calories;
        }

        public void TrackWorkout()
        {
            Console.WriteLine("Strength workout tracked successfully.");
        }

        public override void DisplayWorkout()
        {
            Console.WriteLine($"[Strength] Sets: {Sets}, Reps: {Reps} | Duration: {Duration} mins | Calories: {Calories}");
        }
    }
}
