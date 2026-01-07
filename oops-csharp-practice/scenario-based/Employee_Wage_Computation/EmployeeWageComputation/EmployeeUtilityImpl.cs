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

        // UC-1
        public void CheckAttendance(Employee employee)
        {
            // 0 = Absent, 1 = Full Time, 2 = Part Time
            int attendance = random.Next(0, 3);
            employee.Attendance = attendance;

            if (attendance == 1)
                Console.WriteLine($"{employee.Name} is Present (Full Time)");
            else if (attendance == 2)
                Console.WriteLine($"{employee.Name} is Present (Part Time)");
            else
                Console.WriteLine($"{employee.Name} is Absent");
        }

        // UC-2 (Full Day Wage)
        public void CalculateDailyWage(Employee employee)
        {
            if (employee.Attendance == 1)
            {
                employee.DailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
                Console.WriteLine($"Full Day Wage: {employee.DailyWage}");
            }
        }

        // UC-3 (Part Time Wage)
        public void CalculatePartTimeWage(Employee employee)
        {
            if (employee.Attendance == 2)
            {
                employee.DailyWage = WAGE_PER_HOUR * PART_TIME_HOURS;
                Console.WriteLine($"Part Time Wage: {employee.DailyWage}");
            }
        }
    }
}
