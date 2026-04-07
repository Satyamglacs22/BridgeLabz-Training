using System;

namespace TrafficManager
{
    public interface IVehicle
    {
        void EnterVehicle(int vehicleId);
        void ExitVehicle();
        void DisplayStatus();
    }
}
