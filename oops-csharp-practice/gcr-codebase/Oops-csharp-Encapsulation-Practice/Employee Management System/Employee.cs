using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Employee_Management_System
{
    

    public abstract class Employee
    {
        private int employeeId;
        private string name;
        protected double baseSalary;

        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                if (value > 0)
                    employeeId = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        // Abstract method (must be implemented by child)
        public abstract double CalculateSalary();

        // Concrete method
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID   : " + EmployeeId);
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Salary        : " + CalculateSalary());
        }
    }


}
