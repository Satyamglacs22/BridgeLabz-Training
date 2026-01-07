using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation.EmployeeWageComputation { 
    public class Employee
    {
        private int employeeId;
        private string name;
        private double employeeSalary;
        private int attendance; // UC-1

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double EmployeeSalary
        {
            get { return employeeSalary; }
            set { employeeSalary = value; }
        }

        public int Attendance
        {
            get { return attendance; }
            set { attendance = value; }
        }
    }
}
