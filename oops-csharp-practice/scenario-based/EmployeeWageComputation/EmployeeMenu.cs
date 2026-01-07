using System;

namespace EmployeeWageComputation
{
    public sealed class EmployeeMenu
    {
        private IEmployee service;
        private Employee employee;

        public EmployeeMenu()
        {
            service = new EmployeeUtilityImpl();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Console.WriteLine("Enter Employee Id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            double salary = double.Parse(Console.ReadLine());

            employee = service.AddEmployee(id, name,salary);

            // UC-1 applied
            service.CheckAttendance(employee);
        }
    }
}
