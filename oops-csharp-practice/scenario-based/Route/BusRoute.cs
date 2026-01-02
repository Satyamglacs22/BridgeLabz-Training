using System;

namespace Route
{
    public class BusRoute
    {
        public static void Main()
        {
            BusRoute b = new BusRoute();

            Console.WriteLine("Enter number of stoppages:");
            int n = int.Parse(Console.ReadLine());

            string[] stops = new string[n];
            int[] dist = new int[n];   // dist[i] = distance from stop i-1 to i

            // Input stoppages and distances
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter stoppage {i + 1} name:");
                stops[i] = Console.ReadLine();

                if (i == 0)
                {
                    dist[i] = 0; // no distance before first stoppage
                }
                else
                {
                    Console.WriteLine("Enter distance from previous stoppage:");
                    dist[i] = int.Parse(Console.ReadLine());
                }
            }

            // Calculate prefix sum of distances
            int[] prefix = b.CalculatePrefixSum(dist);

            // Passenger distance calculation
            b.EachPassengers(stops, prefix, n);
        }

        // Handles multiple passengers
        public void EachPassengers(string[] stops, int[] prefix, int n)
        {
            Console.WriteLine("\nEnter number of passengers:");
            int passengers = int.Parse(Console.ReadLine());

            for (int p = 1; p <= passengers; p++)
            {
                Console.WriteLine($"\nPassenger {p}");

                Console.WriteLine($"Enter boarding stoppage number (1 to {n}):");
                int board = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine($"Enter drop stoppage number (1 to {n}):");
                int drop = int.Parse(Console.ReadLine()) - 1;

                // Validation
                if (board < 0 || drop < 0 || board >= n || drop >= n)
                {
                    Console.WriteLine("Invalid stoppage number.");
                    continue;
                }

                if (drop <= board)
                {
                    Console.WriteLine("Drop stoppage must be after boarding stoppage.");
                    continue;
                }

                // Distance calculation (correct logic)
                int covered = prefix[drop] - prefix[board];

                Console.WriteLine($"Boarded at: {stops[board]}");
                Console.WriteLine($"Dropped at: {stops[drop]}");
                Console.WriteLine($"Total Distance Covered: {covered}");
            }
        }

        // Prefix sum calculation
        public int[] CalculatePrefixSum(int[] dist)
        {
            int[] prefix = new int[dist.Length];
            prefix[0] = 0;

            for (int i = 1; i < dist.Length; i++)
            {
                prefix[i] = prefix[i - 1] + dist[i];
            }

            return prefix;
        }
    }
}
