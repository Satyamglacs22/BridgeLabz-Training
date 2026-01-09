using System;

namespace Fitness_Tracker
{
    internal class CardioWorkout : Workout, ITrackable
    {
        public double Distance { get; set; } // km

        public int CalculateCalories()
        {
            Calories = (int)(Distance * 60);
            return Calories;
        }

        public void TrackWorkout()
        {
            Console.WriteLine("Cardio workout tracked successfully.");
        }

        public override void DisplayWorkout()
        {
            Console.WriteLine($"[Cardio] Distance: {Distance} km | Duration: {Duration} mins | Calories: {Calories}");
        }
    }
}
