using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation.EmployeeWageComputation
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

                employee = service.AddEmployee(id, name);

                // UC-1 applied
                service.CheckAttendance(employee);


               // UC-2
              service.CalculateDailyWage(employee);

        }
    }

}
