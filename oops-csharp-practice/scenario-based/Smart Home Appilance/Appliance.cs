using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home_Appilance
{
    public class Appliance
    {
        private string applianceName;
        public string ApplianceName
        {
            get{ return applianceName; }

            set{ applianceName = value; }

        }
        public void DisplayAppliance()
        {
            Console.WriteLine($"ApplianceName is :{applianceName}");
        }
    }
}
