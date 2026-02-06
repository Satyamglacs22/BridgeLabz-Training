using Review1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    public class InPatient : Patient, IPayable
    {
        private int perDayCharge;
        private int noOfDays;
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
        public int PerDayCharge
        {
            get
            {
                return perDayCharge;
            }
            set
            {
                perDayCharge = value;
            }
        }

        public int NoOfDays
        {
            get
            {
                return noOfDays;
            }
            set
            {
                noOfDays = value;
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
            return (perDayCharge * noOfDays) + consultationFee;
        }

    }
}
