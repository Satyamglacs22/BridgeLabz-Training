using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home_Appilance
{
    public class Fan : Appliance, IControllable
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is Turned On");

        }
        public void TurnOff()
        {
            Console.WriteLine("Fan is Turned Off");
        }
    }
}
