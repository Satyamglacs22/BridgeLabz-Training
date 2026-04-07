using System;

namespace Pipe_Cutting
{
    class PipeUtility : Pipe, ICutting
    {
        public void CuttingRod()
        {
            // ---------- User Input ----------
            Console.Write("Enter number of available lengths: ");
            int n = int.Parse(Console.ReadLine());

            int[] lengths = PipeInput.TakeLengths(n);
            int[] prices = PipeInput.TakePrices(n);

            PipeLength = PipeInput.TakePipeLength();

            // ---------- Scenario A ----------
            int scenarioARevenue = CalculateMaxRevenue(lengths, prices, PipeLength);
            Console.WriteLine("\nScenario A Maximum Revenue : " + scenarioARevenue);

            // ---------- Scenario B ----------
            Console.Write("\nEnter Custom Length: ");
            int customLength = int.Parse(Console.ReadLine());

            // Fixed price chart se price nikaalna
            int customPrice = prices[customLength - 1];

            int remainingLength = PipeLength - customLength;

            int remainingRevenue = CalculateMaxRevenue(
                lengths, prices, remainingLength
            );

            int scenarioBRevenue = customPrice + remainingRevenue;

            Console.WriteLine("Scenario B Revenue : " + scenarioBRevenue);

            //--------------Scenario C------------------

            CheckValid(PipeLength, customLength);

            // ---------- Profit / Loss ----------
            if (scenarioBRevenue > scenarioARevenue)
                Console.WriteLine("Owner is in PROFIT");
            else
                Console.WriteLine("Owner is in LOSS");
        }

        // ---------- Common Two Pointer Logic ----------
        private int CalculateMaxRevenue(int[] lengths, int[] prices, int targetLength)
        {
            int left = 0;
            int right = lengths.Length - 1;
            int maxRevenue = 0;

            // Case: sell whole pipe if available
            for (int i = 0; i < lengths.Length; i++)
            {
                if (lengths[i] == targetLength)
                    maxRevenue = prices[i];
            }

            // Case: one cut only (two pointer)
            while (left < right)
            {
                int sumLength = lengths[left] + lengths[right];

                if (sumLength == targetLength)
                {
                    int sumPrice = prices[left] + prices[right];
                    if (sumPrice > maxRevenue)
                        maxRevenue = sumPrice;

                    left++;
                    right--;
                }
                else if (sumLength > targetLength)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return maxRevenue;
        }

        public void CheckValid(int pipeLength, int customLength)
        {

            if (customLength > pipeLength)
            {
                Console.WriteLine("Error Occurs");
            }
            else
            {
                Console.WriteLine("No Error Found");
            }

        }
    }
}
