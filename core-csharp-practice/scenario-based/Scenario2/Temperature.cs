using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysScenario
{
    public class Temperature
    {
        public static void Main()
        {
            Temperature obj = new Temperature();

            // 2D array to store temperatures of 7 days and 24 hours
            float[,] temperatures = new float[7, 24];

            Random random = new Random();

            // Generating random temperature values
            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine($"\nTemperatures for Day {day + 1}:");

                for (int hour = 0; hour < 24; hour++)
                {
                    temperatures[day, hour] = random.Next(0, 51); // 0 to 50
                    Console.WriteLine($"Hour {hour + 1}: {temperatures[day, hour]} °C");
                }
            }

            // Calling analysis method
            obj.AnalyzeTemperature(temperatures);
        }

        public void AnalyzeTemperature(float[,] temps)
        {
            int hottestDay = 0;
            int coldestDay = 0;

            float maxAvg = float.MinValue;
            float minAvg = float.MaxValue;

            for (int day = 0; day < 7; day++)
            {
                float sum = 0;

                for (int hour = 0; hour < 24; hour++)
                {
                    sum += temps[day, hour];
                }

                float average = sum / 24;
                Console.WriteLine($"\nAverage temperature of Day {day + 1}: {average}");

                if (average > maxAvg)
                {
                    maxAvg = average;
                    hottestDay = day;
                }

                if (average < minAvg)
                {
                    minAvg = average;
                    coldestDay = day;
                }
            }

            Console.WriteLine("\nHottest Day: Day " + (hottestDay + 1));
            Console.WriteLine("Coldest Day: Day " + (coldestDay + 1));
        }
    }
}
