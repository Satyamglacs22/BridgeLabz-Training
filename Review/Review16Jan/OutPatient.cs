using System;
using System.Collections.Generic;
using System.Text;

namespace Review1
{
    public class OutPatient : Patient, IPayable
    {
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
                consultationFee = value;
            }
        }

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
