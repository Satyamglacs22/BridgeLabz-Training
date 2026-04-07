using System;
using System.Collections.Generic;
using System.Text;

namespace Atm_Dispenser
{
    public class AtmDispenser
    {
        public void Dispense(int amount, int[] notes, int[] quantity)
        {
            int remaining = amount;
            int totalGiven = 0;
            int totalNotes = 0;

            Console.WriteLine($"\nRequested Amount: ₹{amount}");

            for (int i = 0; i < notes.Length; i++)
            {
                if (remaining >= notes[i] && quantity[i] > 0)
                {
                    int required = remaining / notes[i];
                    int used = Math.Min(required, quantity[i]);

                    if (used > 0)
                    {
                        Console.WriteLine($"₹{notes[i]} x {used}");
                        remaining -= used * notes[i];
                        totalGiven += used * notes[i];
                        totalNotes += used;
                    }
                }
            }

            if (remaining == 0)
            {
                Console.WriteLine("✔ Exact amount dispensed");
            }
            else
            {
                Console.WriteLine("❌ Exact amount not possible");
                Console.WriteLine($"➡ Fallback amount dispensed: ₹{totalGiven}");
            }

            Console.WriteLine($"Total Amount Given: ₹{totalGiven}");
            Console.WriteLine($"Total Notes Used: {totalNotes}");
        }
    }
}
