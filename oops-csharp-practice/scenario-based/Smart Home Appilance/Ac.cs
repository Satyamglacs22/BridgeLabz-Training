using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home_Appilance
{
    public class Ac:Appliance,IControllable
    {
        public void TurnOn()
        {
            Console.WriteLine("Ac is Turned On");


        }
        public void TurnOff()
        {
            Console.WriteLine("Ac is Turned Off");
        }
    }
}
