using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Employee_Management_System
{
    public class PartTimeEmployee : Employee
    {
        private int hoursWorked;
        private double hourlyRate;

        public PartTimeEmployee(int hoursWorked, double hourlyRate)
        {
            if (hoursWorked > 0)
                this.hoursWorked = hoursWorked;

            if (hourlyRate > 0)
                this.hourlyRate = hourlyRate;
        }

        public override double CalculateSalary()
        {
            return hoursWorked * hourlyRate;
        }
    }


}
