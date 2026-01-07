using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Employee_Wage_Computation.EmployeeWageComputation
{
    public class EmployeeUtilityImpl : IEmployee
    {
        private Random random = new Random();
        private const int WAGE_PER_HOUR = 20;
        private const int FULL_DAY_HOURS = 8;

        public Employee AddEmployee(int id, string name)
        {
            Employee emp = new Employee();
            emp.EmployeeId = id;
            emp.Name = name;
            return emp;
        }

        // UC-1 implementation
        public void CheckAttendance(Employee employee)
        {
            int attendance = random.Next(0, 2);
            employee.Attendance = attendance;

            if (attendance == 1)
                Console.WriteLine($"Employee {employee.Name} is Present");
            else
                Console.WriteLine($"Employee {employee.Name} is Absent");
        }

        // UC-2
        public void CalculateDailyWage(Employee employee)
        {
            if (employee.Attendance == 1)
            {
                employee.DailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
            }
            else
            {
                employee.DailyWage = 0;
            }

            Console.WriteLine($"Daily Wage: {employee.DailyWage}");
        }
    }
}

