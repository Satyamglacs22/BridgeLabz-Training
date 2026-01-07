using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Hospital_Management_System
{
    public class OutPatient : Patient
    {
        private double consultationFee;

        public OutPatient(double fee)
        {
            if (fee > 0)
                consultationFee = fee;
        }

        public override double CalculateBill()
        {
            return consultationFee;
        }
    }

}
