using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home_Appilance
{
    public class Light :Appliance,IControllable
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is Turned On");
        }
        public void TurnOff()
        {
            Console.WriteLine("Light is Turned Off");
        }
    }
}
