using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management_System
{
    public class OutPatient : Patient ,IPayable
    {
        public int consultationFee;
        public Doctor Doctor;


       public override void DisplayInfo()
        {
            base.DisplayInfo();
            Doctor.DisplayDoctorInfo();

            Console.WriteLine($"Consultation Fee is : {consultationFee}");
        }
        public int Fee()
        {
            return consultationFee;
        }

    }
}
