using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation.EmployeeWageComputation
{
    public class Employee
    {
        private int employeeId;
        private string name;
        private int attendance;
        private double dailyWage;
        private double monthlyWage;
        private int workingDays;

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

        public int Attendance
        {
            get { return attendance; }
            set { attendance = value; }
        }

        public double DailyWage
        {
            get { return dailyWage; }
            set { dailyWage = value; }
        }

        public double MonthlyWage
        {
            get { return monthlyWage; }
            set { monthlyWage = value; }
        }

        public int WorkingDays
        {
            get { return workingDays; }
            set { workingDays = value; }
        }
    }
}
