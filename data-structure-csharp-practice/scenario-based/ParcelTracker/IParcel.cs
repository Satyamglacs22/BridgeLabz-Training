using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracker
{
    internal interface IParcel
        
    {
        void CreateDefaultStage();

        void TrackParcel();
        void AddCheckPoint(string afterStage,string newStage);
        void ValidateParcel();

    }
}
