using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation.EmployeeWageComputation
{
    public class EmployeeUtilityImpl : IEmployee
    {
        private const int WAGE_PER_HOUR = 20;
        private const int FULL_DAY_HOURS = 8;
        private const int PART_TIME_HOURS = 4;

        private Random random = new Random();

        public Employee AddEmployee(int id, string name)
        {
            Employee emp = new Employee();
            emp.EmployeeId = id;
            emp.Name = name;
            return emp;
        }

        // UC1
        public void CheckAttendance(Employee employee)
        {
            int attendance = random.Next(0, 3); // 0-Absent,1-Full,2-Part
            employee.Attendance = attendance;

            if (attendance == 1)
                Console.WriteLine("Present (Full Time)");
            else if (attendance == 2)
                Console.WriteLine("Present (Part Time)");
            else
                Console.WriteLine("Absent");
        }

        // UC2 + UC3 (IF-ELSE)
        public void CalculateDailyWage(Employee employee)
        {
            if (employee.Attendance == 1)
                employee.DailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
            else if (employee.Attendance == 2)
                employee.DailyWage = WAGE_PER_HOUR * PART_TIME_HOURS;
            else
                employee.DailyWage = 0;

            Console.WriteLine("Daily Wage: " + employee.DailyWage);
        }

        // UC4 (Switch Case)
        public void CalculateDailyWageUsingSwitch(Employee employee)
        {
            int workHours;

            switch (employee.Attendance)
            {
                case 1:
                    workHours = FULL_DAY_HOURS;
                    break;
                case 2:
                    workHours = PART_TIME_HOURS;
                    break;
                default:
                    workHours = 0;
                    break;
            }

            employee.DailyWage = workHours * WAGE_PER_HOUR;
            Console.WriteLine("Daily Wage (Switch): " + employee.DailyWage);
        }

        // UC5 (Monthly Wage with Random Days 1–23)
        public void CalculateMonthlyWage(Employee employee)
        {
            int daysWorked = random.Next(1, 24);
            employee.WorkingDays = daysWorked;

            double totalWage = 0;

            Console.WriteLine("\nEmployee worked for " + daysWorked + " days\n");

            for (int day = 1; day <= daysWorked; day++)
            {
                Console.WriteLine("Day " + day);
                CheckAttendance(employee);
                CalculateDailyWageUsingSwitch(employee);
                totalWage += employee.DailyWage;
                Console.WriteLine();
            }

            employee.MonthlyWage = totalWage;
            Console.WriteLine("Total Monthly Wage: " + employee.MonthlyWage);
        }
    }
}
