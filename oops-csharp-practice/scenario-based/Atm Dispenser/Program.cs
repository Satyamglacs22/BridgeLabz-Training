using System;

namespace Atm_Dispenser
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of denominations: ");
            int n = int.Parse(Console.ReadLine());

            int[] notes = new int[n];
            int[] quantity = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter denomination value: ");
                notes[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter number of notes: ");
                quantity[i] = int.Parse(Console.ReadLine());
            }

            // Sort notes & quantities in descending order
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (notes[i] < notes[j])
                    {
                        // swap notes
                        int temp = notes[i];
                        notes[i] = notes[j];
                        notes[j] = temp;

                        // swap quantity
                        temp = quantity[i];
                        quantity[i] = quantity[j];
                        quantity[j] = temp;
                    }
                }
            }

            Console.Write("\nEnter amount to withdraw: ");
            int amount = int.Parse(Console.ReadLine());

            AtmDispenser atm = new AtmDispenser();
            atm.Dispense(amount, notes, quantity);
        }
    }
}
