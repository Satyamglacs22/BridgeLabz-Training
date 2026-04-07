using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCheckout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartCheckoutMenu menu = new SmartCheckoutMenu();
            menu.ShowMenu();
        }
    }
}
