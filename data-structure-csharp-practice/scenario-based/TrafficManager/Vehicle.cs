using System;

namespace TrafficManager
{
    public class Vehicle
    {
        private int vehicleId;
        private Vehicle next;

        // Constructor
        public Vehicle(int vehicleId)
        {
            this.vehicleId = vehicleId;
            this.next = null;
        }

        // Read-only VehicleId
        public int VehicleId
        {
            get { return vehicleId; }
        }

        // Next reference (for Queue & Circular Linked List)
        public Vehicle Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
