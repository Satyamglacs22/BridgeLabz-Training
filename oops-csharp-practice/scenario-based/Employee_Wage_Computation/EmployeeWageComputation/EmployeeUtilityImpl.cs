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
            int attendance = random.Next(0, 3); // 0,1,2
            employee.Attendance = attendance;

            Console.WriteLine(
                attendance == 1 ? $"{employee.Name} is Present (Full Time)" :
                attendance == 2 ? $"{employee.Name} is Present (Part Time)" :
                                  $"{employee.Name} is Absent"
            );
        }

        // UC-2
        public void CalculateDailyWage(Employee employee)
        {
            if (employee.Attendance == 1)
            {
                employee.DailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
                Console.WriteLine($"Full Day Wage: {employee.DailyWage}");
            }
        }

        // UC-3
        public void CalculatePartTimeWage(Employee employee)
        {
            if (employee.Attendance == 2)
            {
                employee.DailyWage = WAGE_PER_HOUR * PART_TIME_HOURS;
                Console.WriteLine($"Part Time Wage: {employee.DailyWage}");
            }
        }

        // ✅ UC-4: Switch Case Implementation
        public void CalculateDailyWageUsingSwitch(Employee employee)
        {
            int workHours = 0;

            switch (employee.Attendance)
            {
                case 1: // Full Time
                    workHours = FULL_DAY_HOURS;
                    break;

                case 2: // Part Time
                    workHours = PART_TIME_HOURS;
                    break;

                default: // Absent
                    workHours = 0;
                    break;
            }

            employee.DailyWage = workHours * WAGE_PER_HOUR;
            Console.WriteLine($"Daily Wage (Switch Case): {employee.DailyWage}");
        }
    }
}
