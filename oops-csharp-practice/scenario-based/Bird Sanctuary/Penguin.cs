using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary
{
    public class Penguin : Bird, ISwimmable, IWalk
    {
        public Penguin(string name, string color) : base(name, color) { }

        public void Swim()
        {
            Console.WriteLine("Penguin Can Swim");
        }
        public void Walk()
        {
            Console.WriteLine("Penguin Can Walk");

        }
    }

}
