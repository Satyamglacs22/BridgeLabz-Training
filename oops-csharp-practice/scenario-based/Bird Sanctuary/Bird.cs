using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary
{
    

    public class Bird
    {
        protected string name;
        protected string color;

        public Bird(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Bird Name: " + name);
            Console.WriteLine("Bird Color: " + color);
        }
    }

}
