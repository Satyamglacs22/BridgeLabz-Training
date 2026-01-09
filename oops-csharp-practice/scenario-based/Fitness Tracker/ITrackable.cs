using System;

namespace Fitness_Tracker
{
    internal interface ITrackable
    {
        int CalculateCalories();
        void TrackWorkout();
    }
}
