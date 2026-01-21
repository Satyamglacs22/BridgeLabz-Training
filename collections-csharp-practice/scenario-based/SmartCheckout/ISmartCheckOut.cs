using System;

namespace SmartCheckout
{
    internal interface ISmartCheckout
    {
        void AddCustomer(Customer customer);
        void RemoveCustomer();
        void ProcessBilling();
    }
}
