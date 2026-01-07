using System;

namespace EmployeeWageComputation
{
    public class EmployeeUtilityImpl : IEmployee
    {
        private Random random = new Random();

        public Employee AddEmployee(int id, string name, double salary)
        {
            Employee emp = new Employee();
            emp.EmployeeId = id;
            emp.Name = name;
            emp.EmployeeSalary = salary;
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
