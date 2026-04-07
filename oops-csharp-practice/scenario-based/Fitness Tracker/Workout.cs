using System;

namespace Fitness_Tracker
{
    public abstract class Workout
    {
        public string WorkoutName { get; set; }
        public int Duration { get; set; }
        public int Calories { get; protected set; }

        public virtual void DisplayWorkout()
        {
            Console.WriteLine($"Workout: {WorkoutName} | Duration: {Duration} mins | Calories: {Calories}");
        }
    }
}
