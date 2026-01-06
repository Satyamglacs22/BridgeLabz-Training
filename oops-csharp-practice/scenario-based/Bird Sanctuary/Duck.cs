using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary
{
    public class Duck : Bird, ISwimmable, IWalk
    {
        public Duck(string name, string color) : base(name, color) { }

        public void Swim()
        {
            Console.WriteLine("Duck Can Swim");
        }
        public void Walk()
        {
            Console.WriteLine("Duck Can Walk");

        }
    }

}
