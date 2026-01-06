using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management_System
{
    public class InPatient:Patient, IPayable
    {
        public int perDayCharge;
        public int noOfDays;
        private int consultationFee;
        public Doctor Doctor;

        public int ConsultationFee
        {
            get
            {
                return consultationFee;
            }
            set
            {
                if (value > 100)
                {
                    consultationFee = value;
                }
                else
                    Console.WriteLine("Consultation Fee must be positive");
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Doctor.DisplayDoctorInfo();

            Console.WriteLine($"Per day Charges is : {perDayCharge}");
            Console.WriteLine($"No of Days Stayed at Hospital : {noOfDays}");
        }

        public int Fee()
        {
            return (perDayCharge * noOfDays)+ consultationFee;
        }

    }
}
