using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary
{
    using System;

    public class Utility
    {
        public static void Main()
        {
            // Array of Bird (Polymorphism)
            Bird[] birds = new Bird[5];

            birds[0] = new Eagle("Eagle", "Brown");
            birds[1] = new Sparrow("Sparrow", "Grey");
            birds[2] = new Duck("Duck", "White");
            birds[3] = new Penguin("Penguin", "Black & White");
            birds[4] = new Seagull("Seagull", "White");

            for (int i = 0; i < birds.Length; i++)
            {
                Console.WriteLine("\n----------------------");
                birds[i].DisplayInfo();

                // IFlyable check
                if (birds[i] is IFlyable)
                {
                    ((IFlyable)birds[i]).Fly();
                }

                // ISwimmable check
                if (birds[i] is ISwimmable)
                {
                    ((ISwimmable)birds[i]).Swim();
                }
                if (birds[i] is IWalk)
                {
                    ((IWalk)birds[i]).Walk();
                }
            }
        }
    }

}
