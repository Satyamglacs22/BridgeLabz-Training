using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary
{
    public class Seagull : Bird, IFlyable, ISwimmable, IWalk
    {
        public Seagull(string name, string color) : base(name, color) { 

        }

        public void Fly()
        {
            Console.WriteLine("Seagull Can Fly");
        }

        public void Swim()
        {
            Console.WriteLine("Seagull Can Swim");
        }
        public void Walk()
        {
            Console.WriteLine("Seagull Can Walk");

        }
    }

}
