using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCheckout
{
    internal class Customer
    {
        public string CustomerName { get; set; }
        public List<string> Items { get; set; }

        public Customer(string name)
        {
            CustomerName = name;
            Items = new List<string>();
        }
    }
}
