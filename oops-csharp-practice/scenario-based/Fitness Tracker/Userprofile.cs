using System;
using System.Collections.Generic;

namespace Fitness_Tracker
{
    public class Userprofile
    {
        private string name;
        private int age;
        private string gender;

        private List<Workout> workouts = new List<Workout>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public void AddWorkout(Workout workout)
        {
            workouts.Add(workout);
        }

        public void DisplayUser()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
        }

        public void ShowWorkouts()
        {
            if (workouts.Count == 0)
            {
                Console.WriteLine("No workouts done yet.");
                return;
            }

            Console.WriteLine("\n--- Workout History ---");
            foreach (var w in workouts)
            {
                w.DisplayWorkout();
            }
        }

        public void ShowTotalCalories()
        {
            int total = 0;
            foreach (var w in workouts)
            {
                total += w.Calories;
            }
            Console.WriteLine($"Total Calories Burned: {total}");
        }
    }
}
