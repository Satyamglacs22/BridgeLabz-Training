using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracker
{
    internal class ParcelMain
    {
        static void Main(string[] args)
        {
            ParcelMenu menu = new ParcelMenu();
            menu.ShowMenu();
        }
    }
}
