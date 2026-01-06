using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental
{
    public interface IRentable
    {
        int CalculateRent(int days);
    }
}
