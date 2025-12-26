using System;
using System.Collections.Generic;
using System.Text;

namespace Level3
{
    public class Bonus
    {
        public static void Main()
        {
            double[,] data = GenerateEmployeeData();
            double[,] updated = CalculateBonus(data);
            DisplaySummary(data, updated);
        }

        public static double[,] GenerateEmployeeData()
        {
            Random random = new Random();
            double[,] data = new double[10, 2];

            for (int i = 0; i < 10; i++)
            {
                data[i, 0] = random.Next(10000, 99999);
                data[i, 1] = random.Next(1, 11);
            }

            return data;
        }

        public static double[,] CalculateBonus(double[,] data)
        {
            double[,] result = new double[10, 2];

            for (int i = 0; i < 10; i++)
            {
                double salary = data[i, 0];
                double years = data[i, 1];
                double bonusRate = years > 5 ? 0.05 : 0.02;
                double bonus = salary * bonusRate;

                result[i, 0] = salary + bonus;
                result[i, 1] = bonus;
            }

            return result;
        }

        public static void DisplaySummary(double[,] oldData, double[,] newData)
        {
            double oldSum = 0, newSum = 0, bonusSum = 0;

            for (int i = 0; i < 10; i++)
            {
                oldSum += oldData[i, 0];
                newSum += newData[i, 0];
                bonusSum += newData[i, 1];
            }

            Console.WriteLine(oldSum);
            Console.WriteLine(newSum);
            Console.WriteLine(bonusSum);
        }
    }
}
