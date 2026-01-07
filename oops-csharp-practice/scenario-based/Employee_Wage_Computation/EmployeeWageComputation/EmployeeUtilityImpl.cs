using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Employee_Wage_Computation.EmployeeWageComputation
{
    public class EmployeeUtilityImpl : IEmployee
    {
        private Random random = new Random();

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
    }
}

