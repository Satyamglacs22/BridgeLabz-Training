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
        private const int MAX_DAYS = 20;
        private const int MAX_HOURS = 100;

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
            int attendance = random.Next(0, 3); // 0-Absent, 1-Full, 2-Part
            employee.Attendance = attendance;

            if (attendance == 1)
                Console.WriteLine("Present (Full Time)");
            else if (attendance == 2)
                Console.WriteLine("Present (Part Time)");
            else
                Console.WriteLine("Absent");
        }

        // UC-2 + UC-3
        public void CalculateDailyWage(Employee employee)
        {
            if (employee.Attendance == 1)
                employee.DailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
            else if (employee.Attendance == 2)
                employee.DailyWage = WAGE_PER_HOUR * PART_TIME_HOURS;
            else
                employee.DailyWage = 0;
        }

        // UC-4
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
        }

        // UC-5
        public void CalculateMonthlyWage(Employee employee)
        {
            int daysWorked = random.Next(1, 24);
            double totalWage = 0;

            for (int day = 1; day <= daysWorked; day++)
            {
                CheckAttendance(employee);
                CalculateDailyWageUsingSwitch(employee);
                totalWage += employee.DailyWage;
            }

            employee.MonthlyWage = totalWage;
        }

        // ✅ UC-6: Condition based wage calculation
        public void CalculateWageWithCondition(Employee employee)
        {
            int totalDays = 0;
            int totalHours = 0;
            double totalWage = 0;

            Console.WriteLine("\nUC-6 Wage Calculation Started\n");

            while (totalDays < MAX_DAYS && totalHours < MAX_HOURS)
            {
                totalDays++;
                Console.WriteLine("Day " + totalDays);

                CheckAttendance(employee);

                int workHours;
                if (employee.Attendance == 1)
                    workHours = FULL_DAY_HOURS;
                else if (employee.Attendance == 2)
                    workHours = PART_TIME_HOURS;
                else
                    workHours = 0;

                totalHours += workHours;
                totalWage += workHours * WAGE_PER_HOUR;

                Console.WriteLine("Work Hours: " + workHours);
                Console.WriteLine("Total Hours so far: " + totalHours);
                Console.WriteLine();
            }

            employee.WorkingDays = totalDays;
            employee.TotalWorkingHours = totalHours;
            employee.MonthlyWage = totalWage;

            Console.WriteLine("Final Working Days: " + totalDays);
            Console.WriteLine("Final Working Hours: " + totalHours);
            Console.WriteLine("Total Wage (UC-6): " + totalWage);
        }
    }
}
