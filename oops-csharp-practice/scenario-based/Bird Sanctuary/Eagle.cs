using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary
{
    public class Eagle : Bird, IFlyable, IWalk
    {
        public Eagle(string name, string color) : base(name, color) { }

        public void Fly()
        {
            Console.WriteLine("Eagle Can Fly");
        }
        public void Walk()
        {
            Console.WriteLine("Eagle Can Walk");

        }
    }

}
