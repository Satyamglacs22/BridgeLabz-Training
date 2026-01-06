using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary
{
    public class Sparrow : Bird, IFlyable, IWalk
    {
        public Sparrow(string name, string color) : base(name, color) { }

        public void Fly()
        {
            Console.WriteLine("Sparrow Can Fly");
        }
        public void Walk()
        {
            Console.WriteLine("Sparrow Can Walk");

        }
    }

}
