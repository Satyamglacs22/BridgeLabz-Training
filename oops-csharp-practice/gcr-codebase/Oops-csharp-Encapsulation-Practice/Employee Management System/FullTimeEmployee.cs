using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Employee_Management_System
{
    public class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public FullTimeEmployee(double salary)
        {
            baseSalary = salary;
        }

        public override double CalculateSalary()
        {
            return baseSalary;
        }

        public void AssignDepartment(string departmentName)
        {
            department = departmentName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }


}
